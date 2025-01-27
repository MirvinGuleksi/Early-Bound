﻿using System;
using System.Collections.Generic;
using System.Linq;
using AlbanianXrm.Extensions;
using Microsoft.Crm.Services.Utility;
using Microsoft.Xrm.Sdk.Metadata;

namespace AlbanianXrm.CrmSvcUtilExtensions
{
    public sealed class FilteringService : ICodeWriterFilterService
    {
        public FilteringService(ICodeWriterFilterService defaultService)
        {
#if DEBUG
            if ((Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_ATTACHDEBUGGER) ?? "") != "")
            {
                System.Diagnostics.Debugger.Launch();
            }
#endif
            this.DefaultService = defaultService;
            entities = new HashSet<string>((Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_ENTITIES) ?? "").Split(","));
            allAttributes = new HashSet<string>((Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_ALL_ATTRIBUTES) ?? "").Split(","));
            entityAttributes = new Dictionary<string, HashSet<string>>();
            foreach (var entity in entities.Except(allAttributes))
            {
                entityAttributes.Add(entity, new HashSet<string>((Environment.GetEnvironmentVariable(string.Format(Constants.ENVIRONMENT_ENTITY_ATTRIBUTES, entity)) ?? "").Split(",")));
            }

            allRelationships = new HashSet<string>((Environment.GetEnvironmentVariable(Constants.ENVIRONMENT_ALL_RELATIONSHIPS) ?? "").Split(","));
            entity1NRelationships = new Dictionary<string, HashSet<string>>();
            foreach (var entity in entities.Except(allRelationships))
            {
                entity1NRelationships.Add(entity, new HashSet<string>((Environment.GetEnvironmentVariable(string.Format(Constants.ENVIRONMENT_RELATIONSHIPS1N, entity)) ?? "").Split(",")));
            }

            entityN1Relationships = new Dictionary<string, HashSet<string>>();
            foreach (var entity in entities.Except(allRelationships))
            {
                entityN1Relationships.Add(entity, new HashSet<string>((Environment.GetEnvironmentVariable(string.Format(Constants.ENVIRONMENT_RELATIONSHIPSN1, entity)) ?? "").Split(",")));
            }

            entityNNRelationships = new Dictionary<string, HashSet<string>>();
            foreach (var entity in entities.Except(allRelationships))
            {
                entityNNRelationships.Add(entity, new HashSet<string>((Environment.GetEnvironmentVariable(string.Format(Constants.ENVIRONMENT_RELATIONSHIPSNN, entity)) ?? "").Split(",")));
            }
        }

        private ICodeWriterFilterService DefaultService { get; set; }

        private HashSet<string> entities;
        private HashSet<string> allAttributes;
        private HashSet<string> allRelationships;
        private Dictionary<string, HashSet<string>> entityAttributes;
        private Dictionary<string, HashSet<string>> entity1NRelationships;
        private Dictionary<string, HashSet<string>> entityN1Relationships;
        private Dictionary<string, HashSet<string>> entityNNRelationships;

        bool ICodeWriterFilterService.GenerateAttribute(AttributeMetadata attributeMetadata, IServiceProvider services)
        {
            if (attributeMetadata.LogicalName == "statecode" ||
                entityAttributes.TryGetValue(attributeMetadata.EntityLogicalName, out HashSet<string> attributes) &&
                attributes.Contains(attributeMetadata.LogicalName))
            {
                return true;
            }
            else if (!allAttributes.Contains(attributeMetadata.EntityLogicalName) &&
                     (allAttributes.Any() || entityAttributes.Any()))
            {
                return false;
            }
            else
            {
                return this.DefaultService.GenerateAttribute(attributeMetadata, services);
            }
        }

        bool ICodeWriterFilterService.GenerateEntity(EntityMetadata entityMetadata, IServiceProvider services)
        {
            if (entities.Contains(entityMetadata.LogicalName))
            {
                return true;
            }
            else if (entities.Any())
            {
                return false;
            }
            else
            {
                return this.DefaultService.GenerateEntity(entityMetadata, services);
            }
        }

        bool ICodeWriterFilterService.GenerateOption(OptionMetadata optionMetadata, IServiceProvider services)
        {
            return this.DefaultService.GenerateOption(optionMetadata, services);
        }

        bool ICodeWriterFilterService.GenerateOptionSet(OptionSetMetadataBase optionSetMetadata, IServiceProvider services)
        {
            return this.DefaultService.GenerateOptionSet(optionSetMetadata, services);
        }

        bool ICodeWriterFilterService.GenerateRelationship(RelationshipMetadataBase relationshipMetadata, EntityMetadata otherEntityMetadata,
        IServiceProvider services)
        {
            HashSet<string> relationships;
            if (relationshipMetadata is OneToManyRelationshipMetadata oneToManyMetadata)
            {
                if (oneToManyMetadata.ReferencedEntity == oneToManyMetadata.ReferencingEntity)
                {
                    if (allRelationships.Contains(oneToManyMetadata.ReferencedEntity))
                    {
                        return this.DefaultService.GenerateRelationship(relationshipMetadata, otherEntityMetadata, services);
                    }
                    else if (entity1NRelationships.TryGetValue(oneToManyMetadata.ReferencedEntity, out relationships) &&
                        relationships.Contains(oneToManyMetadata.SchemaName) ||
                        entityN1Relationships.TryGetValue(oneToManyMetadata.ReferencingEntity, out relationships) &&
                        relationships.Contains(oneToManyMetadata.SchemaName))
                    {
                        return true;
                    }
                    else if (allRelationships.Any() ||
                             entity1NRelationships.Any() ||
                             entityN1Relationships.Any() ||
                             entityNNRelationships.Any())
                    {
                        return false;
                    }
                }
                else
                {
                    if (oneToManyMetadata.ReferencingEntity == otherEntityMetadata.LogicalName)
                    {
                        if (allRelationships.Contains(oneToManyMetadata.ReferencedEntity))
                        {
                            return this.DefaultService.GenerateRelationship(relationshipMetadata, otherEntityMetadata, services);
                        }
                        else if (entity1NRelationships.TryGetValue(oneToManyMetadata.ReferencedEntity, out relationships) &&
                                 relationships.Contains(oneToManyMetadata.SchemaName))
                        {
                            return true;
                        }
                        else if (allRelationships.Any() ||
                                 entity1NRelationships.Any() ||
                                 entityN1Relationships.Any() ||
                                 entityNNRelationships.Any())
                        {
                            return false;
                        }
                    }

                    if (oneToManyMetadata.ReferencedEntity == otherEntityMetadata.LogicalName)
                    {
                        if (allRelationships.Contains(oneToManyMetadata.ReferencingEntity))
                        {
                            return this.DefaultService.GenerateRelationship(relationshipMetadata, otherEntityMetadata, services);
                        }
                        else if (entityN1Relationships.TryGetValue(oneToManyMetadata.ReferencingEntity, out relationships) &&
                          relationships.Contains(oneToManyMetadata.SchemaName))
                        {
                            return true;
                        }
                        else if (allRelationships.Any() ||
                                 entity1NRelationships.Any() ||
                                 entityN1Relationships.Any() ||
                                 entityNNRelationships.Any())
                        {
                            return false;
                        }
                    }
                }
            }
            else if (relationshipMetadata is ManyToManyRelationshipMetadata manyToManyMetadata)
            {
                if (manyToManyMetadata.Entity1LogicalName == manyToManyMetadata.Entity2LogicalName)
                {
                    if (allRelationships.Contains(manyToManyMetadata.Entity1LogicalName))
                    {
                        return this.DefaultService.GenerateRelationship(relationshipMetadata, otherEntityMetadata, services);
                    }
                    else if (entityNNRelationships.TryGetValue(manyToManyMetadata.Entity1LogicalName, out relationships) &&
                        relationships.Contains(manyToManyMetadata.SchemaName) ||
                        entityNNRelationships.TryGetValue(manyToManyMetadata.Entity2LogicalName, out relationships) &&
                        relationships.Contains(manyToManyMetadata.SchemaName))
                    {
                        return true;
                    }
                    else if (allRelationships.Any() ||
                             entity1NRelationships.Any() ||
                             entityN1Relationships.Any() ||
                             entityNNRelationships.Any())
                    {
                        return false;
                    }
                }
                else
                {
                    if (manyToManyMetadata.Entity2LogicalName == otherEntityMetadata.LogicalName)
                    {
                        if (allRelationships.Contains(manyToManyMetadata.Entity1LogicalName))
                        {
                            return this.DefaultService.GenerateRelationship(relationshipMetadata, otherEntityMetadata, services);
                        }
                        else if (entityNNRelationships.TryGetValue(manyToManyMetadata.Entity1LogicalName, out relationships) &&
                                 relationships.Contains(manyToManyMetadata.SchemaName))
                        {
                            return true;
                        }
                        else if (allRelationships.Any() ||
                                 entity1NRelationships.Any() ||
                                 entityN1Relationships.Any() ||
                                 entityNNRelationships.Any())
                        {
                            return false;
                        }
                    }

                    if (manyToManyMetadata.Entity1LogicalName == otherEntityMetadata.LogicalName)
                    {
                        if (allRelationships.Contains(manyToManyMetadata.Entity2LogicalName))
                        {
                            return this.DefaultService.GenerateRelationship(relationshipMetadata, otherEntityMetadata, services);
                        }
                        else if (entityNNRelationships.TryGetValue(manyToManyMetadata.Entity2LogicalName, out relationships) &&
                          relationships.Contains(manyToManyMetadata.SchemaName))
                        {
                            return true;
                        }
                        else if (allRelationships.Any() ||
                                 entity1NRelationships.Any() ||
                                 entityN1Relationships.Any() ||
                                 entityNNRelationships.Any())
                        {
                            return false;
                        }
                    }
                }
            }
            return this.DefaultService.GenerateRelationship(relationshipMetadata, otherEntityMetadata, services);
        }

        bool ICodeWriterFilterService.GenerateServiceContext(IServiceProvider services)
        {
            return this.DefaultService.GenerateServiceContext(services);
        }
    }
}
