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
    /// <para>The write error object</para>
    /// </summary>
    public class WriteError : enc.IEncodable<WriteError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="WriteError" /> class.</para>
        /// </summary>
        public WriteError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MalformedPath</para>
        /// </summary>
        public bool IsMalformedPath
        {
            get
            {
                return this is MalformedPath;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MalformedPath, or <c>null</c>.</para>
        /// </summary>
        public MalformedPath AsMalformedPath
        {
            get
            {
                return this as MalformedPath;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Conflict</para>
        /// </summary>
        public bool IsConflict
        {
            get
            {
                return this is Conflict;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Conflict, or <c>null</c>.</para>
        /// </summary>
        public Conflict AsConflict
        {
            get
            {
                return this as Conflict;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoWritePermission</para>
        /// </summary>
        public bool IsNoWritePermission
        {
            get
            {
                return this is NoWritePermission;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoWritePermission, or <c>null</c>.</para>
        /// </summary>
        public NoWritePermission AsNoWritePermission
        {
            get
            {
                return this as NoWritePermission;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InsufficientSpace</para>
        /// </summary>
        public bool IsInsufficientSpace
        {
            get
            {
                return this is InsufficientSpace;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InsufficientSpace, or <c>null</c>.</para>
        /// </summary>
        public InsufficientSpace AsInsufficientSpace
        {
            get
            {
                return this as InsufficientSpace;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DisallowedName</para>
        /// </summary>
        public bool IsDisallowedName
        {
            get
            {
                return this is DisallowedName;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DisallowedName, or <c>null</c>.</para>
        /// </summary>
        public DisallowedName AsDisallowedName
        {
            get
            {
                return this as DisallowedName;
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

        #region IEncodable<WriteError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<WriteError>.Encode(enc.IEncoder encoder)
        {
            if (this.IsMalformedPath)
            {
                ((enc.IEncodable<MalformedPath>)this).Encode(encoder);
            }
            else if (this.IsConflict)
            {
                ((enc.IEncodable<Conflict>)this).Encode(encoder);
            }
            else if (this.IsNoWritePermission)
            {
                ((enc.IEncodable<NoWritePermission>)this).Encode(encoder);
            }
            else if (this.IsInsufficientSpace)
            {
                ((enc.IEncodable<InsufficientSpace>)this).Encode(encoder);
            }
            else if (this.IsDisallowedName)
            {
                ((enc.IEncodable<DisallowedName>)this).Encode(encoder);
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
        WriteError enc.IEncodable<WriteError>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "malformed_path":
                using (var obj = decoder.GetObject())
                {
                    return new MalformedPath(obj.GetField<string>("malformed_path"));
                }
            case "conflict":
                var conflict = new WriteConflictError();
                return new Conflict(((enc.IEncodable<WriteConflictError>)conflict).Decode(decoder));
            case "no_write_permission":
                return NoWritePermission.Instance;
            case "insufficient_space":
                return InsufficientSpace.Instance;
            case "disallowed_name":
                return DisallowedName.Instance;
            default:
                return Other.Instance;
            }
        }

        #endregion

        /// <summary>
        /// <para>The malformed path object</para>
        /// </summary>
        public sealed class MalformedPath : WriteError, enc.IEncodable<MalformedPath>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MalformedPath" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public MalformedPath(string value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<MalformedPath>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "malformed_path");
                    obj.AddField("malformed_path", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            MalformedPath enc.IEncodable<MalformedPath>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>Couldn't write to the target path because there was something in the
        /// way.</para>
        /// </summary>
        public sealed class Conflict : WriteError, enc.IEncodable<Conflict>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Conflict" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Conflict(WriteConflictError value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public WriteConflictError Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<Conflict>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "conflict");
                    obj.AddField("conflict", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Conflict enc.IEncodable<Conflict>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The user doesn't have permissions to write to the target location.</para>
        /// </summary>
        public sealed class NoWritePermission : WriteError, enc.IEncodable<NoWritePermission>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoWritePermission" />
            /// class.</para>
            /// </summary>
            private NoWritePermission()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NoWritePermission</para>
            /// </summary>
            public static readonly NoWritePermission Instance = new NoWritePermission();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<NoWritePermission>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "no_write_permission");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            NoWritePermission enc.IEncodable<NoWritePermission>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The user doesn't have enough available space (bytes) to write more
        /// data.</para>
        /// </summary>
        public sealed class InsufficientSpace : WriteError, enc.IEncodable<InsufficientSpace>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InsufficientSpace" />
            /// class.</para>
            /// </summary>
            private InsufficientSpace()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InsufficientSpace</para>
            /// </summary>
            public static readonly InsufficientSpace Instance = new InsufficientSpace();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<InsufficientSpace>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "insufficient_space");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            InsufficientSpace enc.IEncodable<InsufficientSpace>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>Dropbox will not save the file or folder because it of its name.</para>
        /// </summary>
        public sealed class DisallowedName : WriteError, enc.IEncodable<DisallowedName>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DisallowedName" />
            /// class.</para>
            /// </summary>
            private DisallowedName()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DisallowedName</para>
            /// </summary>
            public static readonly DisallowedName Instance = new DisallowedName();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<DisallowedName>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "disallowed_name");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            DisallowedName enc.IEncodable<DisallowedName>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : WriteError, enc.IEncodable<Other>
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
