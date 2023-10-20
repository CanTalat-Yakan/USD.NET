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
    public class GfVec2i : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal GfVec2i(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfVec2i obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~GfVec2i()
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
                        UsdCsPINVOKE.delete_GfVec2i(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public GfVec2i() : this(UsdCsPINVOKE.new_GfVec2i__SWIG_0(), true)
        {
        }

        public GfVec2i(int value) : this(UsdCsPINVOKE.new_GfVec2i__SWIG_1(value), true)
        {
        }

        public GfVec2i(int s0, int s1) : this(UsdCsPINVOKE.new_GfVec2i__SWIG_2(s0, s1), true)
        {
        }

        public static GfVec2i XAxis()
        {
            GfVec2i ret = new GfVec2i(UsdCsPINVOKE.GfVec2i_XAxis(), true);
            return ret;
        }

        public static GfVec2i YAxis()
        {
            GfVec2i ret = new GfVec2i(UsdCsPINVOKE.GfVec2i_YAxis(), true);
            return ret;
        }

        public static GfVec2i Axis(uint i)
        {
            GfVec2i ret = new GfVec2i(UsdCsPINVOKE.GfVec2i_Axis(i), true);
            return ret;
        }

        public GfVec2i Set(int s0, int s1)
        {
            GfVec2i ret = new GfVec2i(UsdCsPINVOKE.GfVec2i_Set(swigCPtr, s0, s1), false);
            return ret;
        }

        public GfVec2i GetProjection(GfVec2i v)
        {
            GfVec2i ret = new GfVec2i(UsdCsPINVOKE.GfVec2i_GetProjection(swigCPtr, GfVec2i.getCPtr(v)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public GfVec2i GetComplement(GfVec2i b)
        {
            GfVec2i ret = new GfVec2i(UsdCsPINVOKE.GfVec2i_GetComplement(swigCPtr, GfVec2i.getCPtr(b)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public int GetLengthSq()
        {
            int ret = UsdCsPINVOKE.GfVec2i_GetLengthSq(swigCPtr);
            return ret;
        }

        public static bool Equals(GfVec2i lhs, GfVec2i rhs)
        {
            bool ret = UsdCsPINVOKE.GfVec2i_Equals(GfVec2i.getCPtr(lhs), GfVec2i.getCPtr(rhs));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        override public int GetHashCode()
        {
            int ret = UsdCsPINVOKE.GfVec2i_GetHashCode(swigCPtr);
            return ret;
        }

        public static bool operator==(GfVec2i lhs, GfVec2i rhs)
        {
            // The Swig binding glue will re-enter this operator comparing to null, so
            // that case must be handled explicitly to avoid an infinite loop. This is still
            // not great, since it crosses the C#/C++ barrier twice. A better approache might
            // be to return a simple value from C++ that can be compared in C#.
            bool lnull = lhs as object == null;
            bool rnull = rhs as object == null;
            return (lnull == rnull) && ((lnull && rnull) || GfVec2i.Equals(lhs, rhs));
        }

        public static bool operator!=(GfVec2i lhs, GfVec2i rhs)
        {
            return !(lhs == rhs);
        }

        override public bool Equals(object rhs)
        {
            return GfVec2i.Equals(this, rhs as GfVec2i);
        }

        protected int GetValue(int index)
        {
            int ret = UsdCsPINVOKE.GfVec2i_GetValue(swigCPtr, index);
            return ret;
        }

        protected void SetValue(int index, int value)
        {
            UsdCsPINVOKE.GfVec2i_SetValue(swigCPtr, index, value);
        }

        public int this[int index]
        {
            get { return GetValue(index); }
            set { SetValue(index, value); }
        }

        public static readonly uint dimension = UsdCsPINVOKE.GfVec2i_dimension_get();
    }
}
