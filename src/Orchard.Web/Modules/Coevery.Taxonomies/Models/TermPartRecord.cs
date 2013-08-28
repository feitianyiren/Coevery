﻿using Orchard.ContentManagement.Records;
namespace Coevery.Taxonomies.Models {
    /// <summary>
    /// Represents a Term of a Taxonomy
    /// </summary>
    public class TermPartRecord : ContentPartRecord {
        public virtual int TaxonomyId { get; set; }

        public virtual bool Selectable { get; set; }
        public virtual int Weight { get; set; }
    }
}
