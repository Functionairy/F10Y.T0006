using System;

using F10Y.T0000;


namespace F10Y.T0006
{
    /// <summary>
    /// Attribute indicating an interface contains tries.
    /// </summary>
    /// <remarks>
    /// <para>The usual Tries instance interface name is the singular 'Try'. Otherwise, tries instance interfaces names should be <b>TriesForX</b>.</para>
    /// The marker attribute is useful for surveying tries interfaces and building a catalogue of tries.
    /// Tries are implemented as default methods on an interface.
    /// Note: there is no draft tries marker since all tries are in a sense "drafts".
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, // Tries are the same as functions (just no input or output arguments).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    [MarkerAttributeMarker]
    public class TriesMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that an interface is *not* a tries interface.
        /// This is useful for marking interfaces that end up in canonical tries code file locations, but are not tries interfaces.
        /// </summary>
        public bool Is_Try { get; }


        public TriesMarkerAttribute(
            bool is_Try = true)
        {
            this.Is_Try = is_Try;
        }
    }
}
