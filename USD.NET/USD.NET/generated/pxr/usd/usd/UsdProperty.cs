//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr
{
    public class UsdProperty : UsdObject
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal UsdProperty(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdProperty_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdProperty obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdProperty()
        {
            Dispose();
        }

        public override void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_UsdProperty(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public UsdProperty() : this(UsdCsPINVOKE.new_UsdProperty(), true)
        {
        }

        public SdfPropertySpecHandleVector GetPropertyStack(UsdTimeCode time)
        {
            SdfPropertySpecHandleVector ret = new SdfPropertySpecHandleVector(UsdCsPINVOKE.UsdProperty_GetPropertyStack__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SdfPropertySpecHandleVector GetPropertyStack()
        {
            SdfPropertySpecHandleVector ret = new SdfPropertySpecHandleVector(UsdCsPINVOKE.UsdProperty_GetPropertyStack__SWIG_1(swigCPtr), true);
            return ret;
        }

        public TfToken GetBaseName()
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.UsdProperty_GetBaseName(swigCPtr), true);
            return ret;
        }

        public TfToken GetNamespace()
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.UsdProperty_GetNamespace(swigCPtr), true);
            return ret;
        }

        public StdStringVector SplitName()
        {
            StdStringVector ret = new StdStringVector(UsdCsPINVOKE.UsdProperty_SplitName(swigCPtr), true);
            return ret;
        }

        public string GetDisplayGroup()
        {
            string ret = UsdCsPINVOKE.UsdProperty_GetDisplayGroup(swigCPtr);
            return ret;
        }

        public bool SetDisplayGroup(string displayGroup)
        {
            bool ret = UsdCsPINVOKE.UsdProperty_SetDisplayGroup(swigCPtr, displayGroup);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool ClearDisplayGroup()
        {
            bool ret = UsdCsPINVOKE.UsdProperty_ClearDisplayGroup(swigCPtr);
            return ret;
        }

        public bool HasAuthoredDisplayGroup()
        {
            bool ret = UsdCsPINVOKE.UsdProperty_HasAuthoredDisplayGroup(swigCPtr);
            return ret;
        }

        public StdStringVector GetNestedDisplayGroups()
        {
            StdStringVector ret = new StdStringVector(UsdCsPINVOKE.UsdProperty_GetNestedDisplayGroups(swigCPtr), true);
            return ret;
        }

        public bool SetNestedDisplayGroups(StdStringVector nestedGroups)
        {
            bool ret = UsdCsPINVOKE.UsdProperty_SetNestedDisplayGroups(swigCPtr, StdStringVector.getCPtr(nestedGroups));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public string GetDisplayName()
        {
            string ret = UsdCsPINVOKE.UsdProperty_GetDisplayName(swigCPtr);
            return ret;
        }

        public bool SetDisplayName(string name)
        {
            bool ret = UsdCsPINVOKE.UsdProperty_SetDisplayName(swigCPtr, name);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool ClearDisplayName()
        {
            bool ret = UsdCsPINVOKE.UsdProperty_ClearDisplayName(swigCPtr);
            return ret;
        }

        public bool HasAuthoredDisplayName()
        {
            bool ret = UsdCsPINVOKE.UsdProperty_HasAuthoredDisplayName(swigCPtr);
            return ret;
        }

        public bool IsCustom()
        {
            bool ret = UsdCsPINVOKE.UsdProperty_IsCustom(swigCPtr);
            return ret;
        }

        public bool SetCustom(bool isCustom)
        {
            bool ret = UsdCsPINVOKE.UsdProperty_SetCustom(swigCPtr, isCustom);
            return ret;
        }

        public bool IsDefined()
        {
            bool ret = UsdCsPINVOKE.UsdProperty_IsDefined(swigCPtr);
            return ret;
        }

        public bool IsAuthored()
        {
            bool ret = UsdCsPINVOKE.UsdProperty_IsAuthored(swigCPtr);
            return ret;
        }

        public bool IsAuthoredAt(UsdEditTarget editTarget)
        {
            bool ret = UsdCsPINVOKE.UsdProperty_IsAuthoredAt(swigCPtr, UsdEditTarget.getCPtr(editTarget));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdProperty FlattenTo(UsdPrim parent)
        {
            UsdProperty ret = new UsdProperty(UsdCsPINVOKE.UsdProperty_FlattenTo__SWIG_0(swigCPtr, UsdPrim.getCPtr(parent)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdProperty FlattenTo(UsdPrim parent, TfToken propName)
        {
            UsdProperty ret = new UsdProperty(UsdCsPINVOKE.UsdProperty_FlattenTo__SWIG_1(swigCPtr, UsdPrim.getCPtr(parent), TfToken.getCPtr(propName)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdProperty FlattenTo(UsdProperty property)
        {
            UsdProperty ret = new UsdProperty(UsdCsPINVOKE.UsdProperty_FlattenTo__SWIG_2(swigCPtr, UsdProperty.getCPtr(property)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
    }
}
