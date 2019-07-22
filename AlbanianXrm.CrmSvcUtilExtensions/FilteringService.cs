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
            if (attributeMetadata.LogicalName != "statecode" &&
                !allAttributes.Contains(attributeMetadata.EntityLogicalName) &&
                entityAttributes.TryGetValue(attributeMetadata.EntityLogicalName, out HashSet<string> attributes) &&
                !attributes.Contains(attributeMetadata.LogicalName))
            {
                return false;
            }
            return this.DefaultService.GenerateAttribute(attributeMetadata, services);
        }

        bool ICodeWriterFilterService.GenerateEntity(EntityMetadata entityMetadata, IServiceProvider services)
        {
            if (entities.Any() && !entities.Contains(entityMetadata.LogicalName))
            {
                return false;
            }
            return this.DefaultService.GenerateEntity(entityMetadata, services);
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
                if ((oneToManyMetadata.ReferencedEntity != otherEntityMetadata.LogicalName ||
                     oneToManyMetadata.ReferencedEntity == oneToManyMetadata.ReferencingEntity) &&
                    !allRelationships.Contains(oneToManyMetadata.ReferencedEntity) &&
                    entity1NRelationships.TryGetValue(oneToManyMetadata.ReferencedEntity, out relationships) &&
                    !relationships.Contains(oneToManyMetadata.SchemaName))
                {
                    return false;
                }
                if (oneToManyMetadata.ReferencingEntity != otherEntityMetadata.LogicalName &&
                    !allRelationships.Contains(oneToManyMetadata.ReferencingEntity) &&
                    entityN1Relationships.TryGetValue(oneToManyMetadata.ReferencingEntity, out relationships) &&
                    !relationships.Contains(oneToManyMetadata.SchemaName))
                {
                    return false;
                }
            }
            else if (relationshipMetadata is ManyToManyRelationshipMetadata manyToManyMetadata)
            {
                if ((manyToManyMetadata.Entity1LogicalName != otherEntityMetadata.LogicalName ||
                      manyToManyMetadata.Entity1LogicalName == manyToManyMetadata.Entity2LogicalName) &&
                    !allRelationships.Contains(manyToManyMetadata.Entity1LogicalName) &&
                    entityNNRelationships.TryGetValue(manyToManyMetadata.Entity1LogicalName, out relationships) &&
                    !relationships.Contains(manyToManyMetadata.SchemaName))
                {
                    return false;
                }
                if (manyToManyMetadata.Entity2LogicalName != otherEntityMetadata.LogicalName &&
                    !allRelationships.Contains(manyToManyMetadata.Entity2LogicalName) &&
                    entityNNRelationships.TryGetValue(manyToManyMetadata.Entity2LogicalName, out relationships) &&
                    !relationships.Contains(manyToManyMetadata.SchemaName))
                {
                    return false;
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
