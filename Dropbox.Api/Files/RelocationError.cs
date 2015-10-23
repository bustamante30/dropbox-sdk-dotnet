// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The relocation error object</para>
    /// </summary>
    public class RelocationError : enc.IEncodable<RelocationError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelocationError" />
        /// class.</para>
        /// </summary>
        public RelocationError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is FromLookup</para>
        /// </summary>
        public bool IsFromLookup
        {
            get
            {
                return this is FromLookup;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FromLookup, or <c>null</c>.</para>
        /// </summary>
        public FromLookup AsFromLookup
        {
            get
            {
                return this as FromLookup;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is FromWrite</para>
        /// </summary>
        public bool IsFromWrite
        {
            get
            {
                return this is FromWrite;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FromWrite, or <c>null</c>.</para>
        /// </summary>
        public FromWrite AsFromWrite
        {
            get
            {
                return this as FromWrite;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is To</para>
        /// </summary>
        public bool IsTo
        {
            get
            {
                return this is To;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a To, or <c>null</c>.</para>
        /// </summary>
        public To AsTo
        {
            get
            {
                return this as To;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is CantCopySharedFolder</para>
        /// </summary>
        public bool IsCantCopySharedFolder
        {
            get
            {
                return this is CantCopySharedFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a CantCopySharedFolder, or <c>null</c>.</para>
        /// </summary>
        public CantCopySharedFolder AsCantCopySharedFolder
        {
            get
            {
                return this as CantCopySharedFolder;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is CantNestSharedFolder</para>
        /// </summary>
        public bool IsCantNestSharedFolder
        {
            get
            {
                return this is CantNestSharedFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a CantNestSharedFolder, or <c>null</c>.</para>
        /// </summary>
        public CantNestSharedFolder AsCantNestSharedFolder
        {
            get
            {
                return this as CantNestSharedFolder;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TooManyFiles</para>
        /// </summary>
        public bool IsTooManyFiles
        {
            get
            {
                return this is TooManyFiles;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TooManyFiles, or <c>null</c>.</para>
        /// </summary>
        public TooManyFiles AsTooManyFiles
        {
            get
            {
                return this as TooManyFiles;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region IEncodable<RelocationError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<RelocationError>.Encode(enc.IEncoder encoder)
        {
            if (this.IsFromLookup)
            {
                ((enc.IEncodable<FromLookup>)this).Encode(encoder);
            }
            else if (this.IsFromWrite)
            {
                ((enc.IEncodable<FromWrite>)this).Encode(encoder);
            }
            else if (this.IsTo)
            {
                ((enc.IEncodable<To>)this).Encode(encoder);
            }
            else if (this.IsCantCopySharedFolder)
            {
                ((enc.IEncodable<CantCopySharedFolder>)this).Encode(encoder);
            }
            else if (this.IsCantNestSharedFolder)
            {
                ((enc.IEncodable<CantNestSharedFolder>)this).Encode(encoder);
            }
            else if (this.IsTooManyFiles)
            {
                ((enc.IEncodable<TooManyFiles>)this).Encode(encoder);
            }
            else
            {
                ((enc.IEncodable<Other>)this).Encode(encoder);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        RelocationError enc.IEncodable<RelocationError>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "from_lookup":
                var fromLookup = new LookupError();
                return new FromLookup(((enc.IEncodable<LookupError>)fromLookup).Decode(decoder));
            case "from_write":
                var fromWrite = new WriteError();
                return new FromWrite(((enc.IEncodable<WriteError>)fromWrite).Decode(decoder));
            case "to":
                var to = new WriteError();
                return new To(((enc.IEncodable<WriteError>)to).Decode(decoder));
            case "cant_copy_shared_folder":
                return CantCopySharedFolder.Instance;
            case "cant_nest_shared_folder":
                return CantNestSharedFolder.Instance;
            case "too_many_files":
                return TooManyFiles.Instance;
            default:
                return Other.Instance;
            }
        }

        #endregion

        /// <summary>
        /// <para>The from lookup object</para>
        /// </summary>
        public sealed class FromLookup : RelocationError, enc.IEncodable<FromLookup>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FromLookup" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public FromLookup(LookupError value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public LookupError Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<FromLookup>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "from_lookup");
                    obj.AddField("from_lookup", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            FromLookup enc.IEncodable<FromLookup>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The from write object</para>
        /// </summary>
        public sealed class FromWrite : RelocationError, enc.IEncodable<FromWrite>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FromWrite" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public FromWrite(WriteError value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public WriteError Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<FromWrite>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "from_write");
                    obj.AddField("from_write", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            FromWrite enc.IEncodable<FromWrite>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The to object</para>
        /// </summary>
        public sealed class To : RelocationError, enc.IEncodable<To>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="To" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public To(WriteError value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public WriteError Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<To>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "to");
                    obj.AddField("to", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            To enc.IEncodable<To>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>Shared folders can't be copied.</para>
        /// </summary>
        public sealed class CantCopySharedFolder : RelocationError, enc.IEncodable<CantCopySharedFolder>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="CantCopySharedFolder" />
            /// class.</para>
            /// </summary>
            private CantCopySharedFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of CantCopySharedFolder</para>
            /// </summary>
            public static readonly CantCopySharedFolder Instance = new CantCopySharedFolder();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<CantCopySharedFolder>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "cant_copy_shared_folder");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            CantCopySharedFolder enc.IEncodable<CantCopySharedFolder>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>Your move operation would result in nested shared folders.  This is not
        /// allowed.</para>
        /// </summary>
        public sealed class CantNestSharedFolder : RelocationError, enc.IEncodable<CantNestSharedFolder>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="CantNestSharedFolder" />
            /// class.</para>
            /// </summary>
            private CantNestSharedFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of CantNestSharedFolder</para>
            /// </summary>
            public static readonly CantNestSharedFolder Instance = new CantNestSharedFolder();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<CantNestSharedFolder>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "cant_nest_shared_folder");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            CantNestSharedFolder enc.IEncodable<CantNestSharedFolder>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The operation would involve more than 10,000 files and folders.</para>
        /// </summary>
        public sealed class TooManyFiles : RelocationError, enc.IEncodable<TooManyFiles>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TooManyFiles" />
            /// class.</para>
            /// </summary>
            private TooManyFiles()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TooManyFiles</para>
            /// </summary>
            public static readonly TooManyFiles Instance = new TooManyFiles();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<TooManyFiles>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "too_many_files");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            TooManyFiles enc.IEncodable<TooManyFiles>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>An unspecified error.</para>
        /// </summary>
        public sealed class Other : RelocationError, enc.IEncodable<Other>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Other>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "other");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Other enc.IEncodable<Other>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
