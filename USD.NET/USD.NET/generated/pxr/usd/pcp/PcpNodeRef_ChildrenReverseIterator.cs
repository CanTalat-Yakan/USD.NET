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
    public class PcpNodeRef_ChildrenReverseIterator : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal PcpNodeRef_ChildrenReverseIterator(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PcpNodeRef_ChildrenReverseIterator obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~PcpNodeRef_ChildrenReverseIterator()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_PcpNodeRef_ChildrenReverseIterator(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public PcpNodeRef_ChildrenReverseIterator() : this(UsdCsPINVOKE.new_PcpNodeRef_ChildrenReverseIterator__SWIG_0(), true)
        {
        }

        public PcpNodeRef_ChildrenReverseIterator(PcpNodeRef_ChildrenIterator arg0) : this(UsdCsPINVOKE.new_PcpNodeRef_ChildrenReverseIterator__SWIG_1(PcpNodeRef_ChildrenIterator.getCPtr(arg0)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public PcpNodeRef_ChildrenReverseIterator(PcpNodeRef node, bool end) : this(UsdCsPINVOKE.new_PcpNodeRef_ChildrenReverseIterator__SWIG_2(PcpNodeRef.getCPtr(node), end), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public PcpNodeRef_ChildrenReverseIterator(PcpNodeRef node) : this(UsdCsPINVOKE.new_PcpNodeRef_ChildrenReverseIterator__SWIG_3(PcpNodeRef.getCPtr(node)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}
