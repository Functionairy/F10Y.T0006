using System;

using F10Y.T0000;


namespace F10Y.T0006
{
    /// <summary>
    /// Attribute indicating an interface contains experiments.
    /// </summary>
    /// <remarks>
    /// <para>Experiments instance interface names should be <b>plural</b>. This is so "IString" and "String" does not class with "String" from system.</para>
    /// Experiments are implemented as default methods on an interface.
    /// The marker attribute is useful for surveying experiments classes and building a catalogue of experiments.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, // Experiments are the same as functions (just no input or output arguments).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    [MarkerAttributeMarker]
    public class ExperimentsMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a class is *not* an experiments class.
        /// This is useful for marking classes that end up canonical experiments code file locations, but are not experiments classes.
        /// </summary>
        public bool Is_Experiments { get; }


        public ExperimentsMarkerAttribute(
            bool is_Experiments = true)
        {
            this.Is_Experiments = is_Experiments;
        }
    }
}
