using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Matheclipse.Core.Expression {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']"
	public partial class F : global::Java.Lang.Object {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/method[@name='$s' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register("$s", "(Ljava/lang/String;)Lorg/matheclipse/core/interfaces/ISymbol;", "")]
		public static unsafe global::Org.Matheclipse.Core.Interfaces.ISymbol CreateSymbol(string p0)
		{
			const string __id = "$s.(Ljava/lang/String;)Lorg/matheclipse/core/interfaces/ISymbol;";
			IntPtr native_p0 = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod(__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.ISymbol>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p0);
			}
		}

		[Register("$str", "(Ljava/lang/String;)Lorg/matheclipse/core/interfaces/IStringX;", "")]
		public static unsafe global::Org.Matheclipse.Core.Interfaces.IExpr CreateString(string p0)
		{
			const string __id = "$str.(Ljava/lang/String;)Lorg/matheclipse/core/interfaces/IStringX;";
			IntPtr native_p0 = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod(__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IExpr>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p0);
			}
		}

		public static class IBuiltInSymbol
		{
			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Abort']"
			[Register("Abort")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Abort
			{
				get
				{
					const string __id = "Abort.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Abs']"
			[Register("Abs")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Abs
			{
				get
				{
					const string __id = "Abs.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AbsArg']"
			[Register("AbsArg")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AbsArg
			{
				get
				{
					const string __id = "AbsArg.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Accumulate']"
			[Register("Accumulate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Accumulate
			{
				get
				{
					const string __id = "Accumulate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AddTo']"
			[Register("AddTo")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AddTo
			{
				get
				{
					const string __id = "AddTo.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AlgebraicNumber']"
			[Register("AlgebraicNumber")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AlgebraicNumber
			{
				get
				{
					const string __id = "AlgebraicNumber.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Algebraics']"
			[Register("Algebraics")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Algebraics
			{
				get
				{
					const string __id = "Algebraics.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='All']"
			[Register("All")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol All
			{
				get
				{
					const string __id = "All.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AllTrue']"
			[Register("AllTrue")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AllTrue
			{
				get
				{
					const string __id = "AllTrue.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Alternatives']"
			[Register("Alternatives")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Alternatives
			{
				get
				{
					const string __id = "Alternatives.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='And']"
			[Register("And")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol And
			{
				get
				{
					const string __id = "And.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AngleVector']"
			[Register("AngleVector")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AngleVector
			{
				get
				{
					const string __id = "AngleVector.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Annuity']"
			[Register("Annuity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Annuity
			{
				get
				{
					const string __id = "Annuity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AnnuityDue']"
			[Register("AnnuityDue")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AnnuityDue
			{
				get
				{
					const string __id = "AnnuityDue.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AntiSymmetric']"
			[Register("AntiSymmetric")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AntiSymmetric
			{
				get
				{
					const string __id = "AntiSymmetric.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AntihermitianMatrixQ']"
			[Register("AntihermitianMatrixQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AntihermitianMatrixQ
			{
				get
				{
					const string __id = "AntihermitianMatrixQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AntisymmetricMatrixQ']"
			[Register("AntisymmetricMatrixQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AntisymmetricMatrixQ
			{
				get
				{
					const string __id = "AntisymmetricMatrixQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AnyTrue']"
			[Register("AnyTrue")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AnyTrue
			{
				get
				{
					const string __id = "AnyTrue.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Apart']"
			[Register("Apart")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Apart
			{
				get
				{
					const string __id = "Apart.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AppellF1']"
			[Register("AppellF1")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AppellF1
			{
				get
				{
					const string __id = "AppellF1.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Append']"
			[Register("Append")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Append
			{
				get
				{
					const string __id = "Append.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AppendTo']"
			[Register("AppendTo")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AppendTo
			{
				get
				{
					const string __id = "AppendTo.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Apply']"
			[Register("Apply")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Apply
			{
				get
				{
					const string __id = "Apply.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcCos']"
			[Register("ArcCos")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcCos
			{
				get
				{
					const string __id = "ArcCos.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcCosh']"
			[Register("ArcCosh")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcCosh
			{
				get
				{
					const string __id = "ArcCosh.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcCot']"
			[Register("ArcCot")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcCot
			{
				get
				{
					const string __id = "ArcCot.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcCoth']"
			[Register("ArcCoth")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcCoth
			{
				get
				{
					const string __id = "ArcCoth.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcCsc']"
			[Register("ArcCsc")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcCsc
			{
				get
				{
					const string __id = "ArcCsc.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcCsch']"
			[Register("ArcCsch")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcCsch
			{
				get
				{
					const string __id = "ArcCsch.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcSec']"
			[Register("ArcSec")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcSec
			{
				get
				{
					const string __id = "ArcSec.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcSech']"
			[Register("ArcSech")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcSech
			{
				get
				{
					const string __id = "ArcSech.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcSin']"
			[Register("ArcSin")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcSin
			{
				get
				{
					const string __id = "ArcSin.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcSinh']"
			[Register("ArcSinh")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcSinh
			{
				get
				{
					const string __id = "ArcSinh.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcTan']"
			[Register("ArcTan")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcTan
			{
				get
				{
					const string __id = "ArcTan.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArcTanh']"
			[Register("ArcTanh")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArcTanh
			{
				get
				{
					const string __id = "ArcTanh.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Arg']"
			[Register("Arg")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Arg
			{
				get
				{
					const string __id = "Arg.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArithmeticGeometricMean']"
			[Register("ArithmeticGeometricMean")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArithmeticGeometricMean
			{
				get
				{
					const string __id = "ArithmeticGeometricMean.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Array']"
			[Register("Array")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Array
			{
				get
				{
					const string __id = "Array.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArrayDepth']"
			[Register("ArrayDepth")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArrayDepth
			{
				get
				{
					const string __id = "ArrayDepth.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArrayPad']"
			[Register("ArrayPad")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArrayPad
			{
				get
				{
					const string __id = "ArrayPad.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArrayQ']"
			[Register("ArrayQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArrayQ
			{
				get
				{
					const string __id = "ArrayQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ArrayReshape']"
			[Register("ArrayReshape")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ArrayReshape
			{
				get
				{
					const string __id = "ArrayReshape.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Arrays']"
			[Register("Arrays")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Arrays
			{
				get
				{
					const string __id = "Arrays.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Assumptions']"
			[Register("Assumptions")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Assumptions
			{
				get
				{
					const string __id = "Assumptions.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AtomQ']"
			[Register("AtomQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AtomQ
			{
				get
				{
					const string __id = "AtomQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Attributes']"
			[Register("Attributes")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Attributes
			{
				get
				{
					const string __id = "Attributes.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Automatic']"
			[Register("Automatic")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Automatic
			{
				get
				{
					const string __id = "Automatic.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Axes']"
			[Register("Axes")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Axes
			{
				get
				{
					const string __id = "Axes.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AxesOrigin']"
			[Register("AxesOrigin")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AxesOrigin
			{
				get
				{
					const string __id = "AxesOrigin.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='AxesStyle']"
			[Register("AxesStyle")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol AxesStyle
			{
				get
				{
					const string __id = "AxesStyle.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Background']"
			[Register("Background")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Background
			{
				get
				{
					const string __id = "Background.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Begin']"
			[Register("Begin")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Begin
			{
				get
				{
					const string __id = "Begin.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BeginPackage']"
			[Register("BeginPackage")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BeginPackage
			{
				get
				{
					const string __id = "BeginPackage.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BellB']"
			[Register("BellB")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BellB
			{
				get
				{
					const string __id = "BellB.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BellY']"
			[Register("BellY")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BellY
			{
				get
				{
					const string __id = "BellY.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BernoulliB']"
			[Register("BernoulliB")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BernoulliB
			{
				get
				{
					const string __id = "BernoulliB.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BernoulliDistribution']"
			[Register("BernoulliDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BernoulliDistribution
			{
				get
				{
					const string __id = "BernoulliDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BesselI']"
			[Register("BesselI")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BesselI
			{
				get
				{
					const string __id = "BesselI.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BesselJ']"
			[Register("BesselJ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BesselJ
			{
				get
				{
					const string __id = "BesselJ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BesselK']"
			[Register("BesselK")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BesselK
			{
				get
				{
					const string __id = "BesselK.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BesselY']"
			[Register("BesselY")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BesselY
			{
				get
				{
					const string __id = "BesselY.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Beta']"
			[Register("Beta")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Beta
			{
				get
				{
					const string __id = "Beta.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BetaRegularized']"
			[Register("BetaRegularized")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BetaRegularized
			{
				get
				{
					const string __id = "BetaRegularized.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BinCounts']"
			[Register("BinCounts")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BinCounts
			{
				get
				{
					const string __id = "BinCounts.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Binomial']"
			[Register("Binomial")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Binomial
			{
				get
				{
					const string __id = "Binomial.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BinomialDistribution']"
			[Register("BinomialDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BinomialDistribution
			{
				get
				{
					const string __id = "BinomialDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BitLength']"
			[Register("BitLength")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BitLength
			{
				get
				{
					const string __id = "BitLength.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Blank']"
			[Register("Blank")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Blank
			{
				get
				{
					const string __id = "Blank.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BlankNullSequence']"
			[Register("BlankNullSequence")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BlankNullSequence
			{
				get
				{
					const string __id = "BlankNullSequence.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BlankSequence']"
			[Register("BlankSequence")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BlankSequence
			{
				get
				{
					const string __id = "BlankSequence.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Block']"
			[Register("Block")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Block
			{
				get
				{
					const string __id = "Block.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Boole']"
			[Register("Boole")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Boole
			{
				get
				{
					const string __id = "Boole.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BooleanConvert']"
			[Register("BooleanConvert")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BooleanConvert
			{
				get
				{
					const string __id = "BooleanConvert.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BooleanMinimize']"
			[Register("BooleanMinimize")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BooleanMinimize
			{
				get
				{
					const string __id = "BooleanMinimize.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BooleanQ']"
			[Register("BooleanQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BooleanQ
			{
				get
				{
					const string __id = "BooleanQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BooleanTable']"
			[Register("BooleanTable")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BooleanTable
			{
				get
				{
					const string __id = "BooleanTable.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BooleanVariables']"
			[Register("BooleanVariables")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BooleanVariables
			{
				get
				{
					const string __id = "BooleanVariables.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='BrayCurtisDistance']"
			[Register("BrayCurtisDistance")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol BrayCurtisDistance
			{
				get
				{
					const string __id = "BrayCurtisDistance.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Break']"
			[Register("Break")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Break
			{
				get
				{
					const string __id = "Break.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CDF']"
			[Register("CDF")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CDF
			{
				get
				{
					const string __id = "CDF.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CForm']"
			[Register("CForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CForm
			{
				get
				{
					const string __id = "CForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CanberraDistance']"
			[Register("CanberraDistance")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CanberraDistance
			{
				get
				{
					const string __id = "CanberraDistance.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Cancel']"
			[Register("Cancel")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Cancel
			{
				get
				{
					const string __id = "Cancel.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CarmichaelLambda']"
			[Register("CarmichaelLambda")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CarmichaelLambda
			{
				get
				{
					const string __id = "CarmichaelLambda.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CartesianProduct']"
			[Register("CartesianProduct")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CartesianProduct
			{
				get
				{
					const string __id = "CartesianProduct.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Cases']"
			[Register("Cases")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Cases
			{
				get
				{
					const string __id = "Cases.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Catalan']"
			[Register("Catalan")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Catalan
			{
				get
				{
					const string __id = "Catalan.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CatalanNumber']"
			[Register("CatalanNumber")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CatalanNumber
			{
				get
				{
					const string __id = "CatalanNumber.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Catch']"
			[Register("Catch")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Catch
			{
				get
				{
					const string __id = "Catch.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Catenate']"
			[Register("Catenate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Catenate
			{
				get
				{
					const string __id = "Catenate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Ceiling']"
			[Register("Ceiling")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Ceiling
			{
				get
				{
					const string __id = "Ceiling.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CentralMoment']"
			[Register("CentralMoment")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CentralMoment
			{
				get
				{
					const string __id = "CentralMoment.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CharacterEncoding']"
			[Register("CharacterEncoding")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CharacterEncoding
			{
				get
				{
					const string __id = "CharacterEncoding.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CharacteristicPolynomial']"
			[Register("CharacteristicPolynomial")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CharacteristicPolynomial
			{
				get
				{
					const string __id = "CharacteristicPolynomial.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ChebyshevT']"
			[Register("ChebyshevT")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ChebyshevT
			{
				get
				{
					const string __id = "ChebyshevT.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ChebyshevU']"
			[Register("ChebyshevU")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ChebyshevU
			{
				get
				{
					const string __id = "ChebyshevU.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ChessboardDistance']"
			[Register("ChessboardDistance")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ChessboardDistance
			{
				get
				{
					const string __id = "ChessboardDistance.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ChiSquareDistribution']"
			[Register("ChiSquareDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ChiSquareDistribution
			{
				get
				{
					const string __id = "ChiSquareDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ChineseRemainder']"
			[Register("ChineseRemainder")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ChineseRemainder
			{
				get
				{
					const string __id = "ChineseRemainder.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CholeskyDecomposition']"
			[Register("CholeskyDecomposition")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CholeskyDecomposition
			{
				get
				{
					const string __id = "CholeskyDecomposition.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Chop']"
			[Register("Chop")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Chop
			{
				get
				{
					const string __id = "Chop.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CirclePoints']"
			[Register("CirclePoints")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CirclePoints
			{
				get
				{
					const string __id = "CirclePoints.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Clear']"
			[Register("Clear")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Clear
			{
				get
				{
					const string __id = "Clear.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ClearAll']"
			[Register("ClearAll")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ClearAll
			{
				get
				{
					const string __id = "ClearAll.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ClearAttributes']"
			[Register("ClearAttributes")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ClearAttributes
			{
				get
				{
					const string __id = "ClearAttributes.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Clip']"
			[Register("Clip")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Clip
			{
				get
				{
					const string __id = "Clip.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Coefficient']"
			[Register("Coefficient")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Coefficient
			{
				get
				{
					const string __id = "Coefficient.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CoefficientList']"
			[Register("CoefficientList")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CoefficientList
			{
				get
				{
					const string __id = "CoefficientList.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CoefficientRules']"
			[Register("CoefficientRules")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CoefficientRules
			{
				get
				{
					const string __id = "CoefficientRules.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Collect']"
			[Register("Collect")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Collect
			{
				get
				{
					const string __id = "Collect.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Colon']"
			[Register("Colon")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Colon
			{
				get
				{
					const string __id = "Colon.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Commonest']"
			[Register("Commonest")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Commonest
			{
				get
				{
					const string __id = "Commonest.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CompatibleUnitQ']"
			[Register("CompatibleUnitQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CompatibleUnitQ
			{
				get
				{
					const string __id = "CompatibleUnitQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Compile']"
			[Register("Compile")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Compile
			{
				get
				{
					const string __id = "Compile.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Complement']"
			[Register("Complement")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Complement
			{
				get
				{
					const string __id = "Complement.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Complex']"
			[Register("Complex")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Complex
			{
				get
				{
					const string __id = "Complex.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ComplexInfinity']"
			[Register("ComplexInfinity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ComplexInfinity
			{
				get
				{
					const string __id = "ComplexInfinity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Complexes']"
			[Register("Complexes")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Complexes
			{
				get
				{
					const string __id = "Complexes.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ComplexExpand']"
			[Register("ComplexExpand")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ComplexExpand
			{
				get
				{
					const string __id = "ComplexExpand.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ComplexityFunction']"
			[Register("ComplexityFunction")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ComplexityFunction
			{
				get
				{
					const string __id = "ComplexityFunction.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ComposeList']"
			[Register("ComposeList")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ComposeList
			{
				get
				{
					const string __id = "ComposeList.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ComposeSeries']"
			[Register("ComposeSeries")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ComposeSeries
			{
				get
				{
					const string __id = "ComposeSeries.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Composition']"
			[Register("Composition")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Composition
			{
				get
				{
					const string __id = "Composition.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CompoundExpression']"
			[Register("CompoundExpression")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CompoundExpression
			{
				get
				{
					const string __id = "CompoundExpression.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Condition']"
			[Register("Condition")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Condition
			{
				get
				{
					const string __id = "Condition.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ConditionalExpression']"
			[Register("ConditionalExpression")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ConditionalExpression
			{
				get
				{
					const string __id = "ConditionalExpression.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Conjugate']"
			[Register("Conjugate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Conjugate
			{
				get
				{
					const string __id = "Conjugate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ConjugateTranspose']"
			[Register("ConjugateTranspose")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ConjugateTranspose
			{
				get
				{
					const string __id = "ConjugateTranspose.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Constant']"
			[Register("Constant")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Constant
			{
				get
				{
					const string __id = "Constant.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ConstantArray']"
			[Register("ConstantArray")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ConstantArray
			{
				get
				{
					const string __id = "ConstantArray.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Continue']"
			[Register("Continue")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Continue
			{
				get
				{
					const string __id = "Continue.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ContinuedFraction']"
			[Register("ContinuedFraction")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ContinuedFraction
			{
				get
				{
					const string __id = "ContinuedFraction.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Convergents']"
			[Register("Convergents")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Convergents
			{
				get
				{
					const string __id = "Convergents.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ConvexHullMesh']"
			[Register("ConvexHullMesh")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ConvexHullMesh
			{
				get
				{
					const string __id = "ConvexHullMesh.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CoprimeQ']"
			[Register("CoprimeQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CoprimeQ
			{
				get
				{
					const string __id = "CoprimeQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Correlation']"
			[Register("Correlation")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Correlation
			{
				get
				{
					const string __id = "Correlation.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Cos']"
			[Register("Cos")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Cos
			{
				get
				{
					const string __id = "Cos.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CosIntegral']"
			[Register("CosIntegral")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CosIntegral
			{
				get
				{
					const string __id = "CosIntegral.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Cosh']"
			[Register("Cosh")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Cosh
			{
				get
				{
					const string __id = "Cosh.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CoshIntegral']"
			[Register("CoshIntegral")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CoshIntegral
			{
				get
				{
					const string __id = "CoshIntegral.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CosineDistance']"
			[Register("CosineDistance")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CosineDistance
			{
				get
				{
					const string __id = "CosineDistance.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Cot']"
			[Register("Cot")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Cot
			{
				get
				{
					const string __id = "Cot.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Coth']"
			[Register("Coth")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Coth
			{
				get
				{
					const string __id = "Coth.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Count']"
			[Register("Count")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Count
			{
				get
				{
					const string __id = "Count.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Covariance']"
			[Register("Covariance")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Covariance
			{
				get
				{
					const string __id = "Covariance.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Cross']"
			[Register("Cross")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Cross
			{
				get
				{
					const string __id = "Cross.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Csc']"
			[Register("Csc")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Csc
			{
				get
				{
					const string __id = "Csc.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Csch']"
			[Register("Csch")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Csch
			{
				get
				{
					const string __id = "Csch.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='CubeRoot']"
			[Register("CubeRoot")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol CubeRoot
			{
				get
				{
					const string __id = "CubeRoot.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Curl']"
			[Register("Curl")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Curl
			{
				get
				{
					const string __id = "Curl.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Cyclotomic']"
			[Register("Cyclotomic")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Cyclotomic
			{
				get
				{
					const string __id = "Cyclotomic.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='D']"
			[Register("D")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol D
			{
				get
				{
					const string __id = "D.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DSolve']"
			[Register("DSolve")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DSolve
			{
				get
				{
					const string __id = "DSolve.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Decrement']"
			[Register("Decrement")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Decrement
			{
				get
				{
					const string __id = "Decrement.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Default']"
			[Register("Default")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Default
			{
				get
				{
					const string __id = "Default.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Defer']"
			[Register("Defer")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Defer
			{
				get
				{
					const string __id = "Defer.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Definition']"
			[Register("Definition")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Definition
			{
				get
				{
					const string __id = "Definition.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Degree']"
			[Register("Degree")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Degree
			{
				get
				{
					const string __id = "Degree.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Delete']"
			[Register("Delete")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Delete
			{
				get
				{
					const string __id = "Delete.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DeleteCases']"
			[Register("DeleteCases")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DeleteCases
			{
				get
				{
					const string __id = "DeleteCases.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DeleteDuplicates']"
			[Register("DeleteDuplicates")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DeleteDuplicates
			{
				get
				{
					const string __id = "DeleteDuplicates.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Denominator']"
			[Register("Denominator")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Denominator
			{
				get
				{
					const string __id = "Denominator.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Depth']"
			[Register("Depth")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Depth
			{
				get
				{
					const string __id = "Depth.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Derivative']"
			[Register("Derivative")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Derivative
			{
				get
				{
					const string __id = "Derivative.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DesignMatrix']"
			[Register("DesignMatrix")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DesignMatrix
			{
				get
				{
					const string __id = "DesignMatrix.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Det']"
			[Register("Det")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Det
			{
				get
				{
					const string __id = "Det.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Diagonal']"
			[Register("Diagonal")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Diagonal
			{
				get
				{
					const string __id = "Diagonal.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DiagonalMatrix']"
			[Register("DiagonalMatrix")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DiagonalMatrix
			{
				get
				{
					const string __id = "DiagonalMatrix.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DiceDissimilarity']"
			[Register("DiceDissimilarity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DiceDissimilarity
			{
				get
				{
					const string __id = "DiceDissimilarity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Differences']"
			[Register("Differences")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Differences
			{
				get
				{
					const string __id = "Differences.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DigitQ']"
			[Register("DigitQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DigitQ
			{
				get
				{
					const string __id = "DigitQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Dimensions']"
			[Register("Dimensions")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Dimensions
			{
				get
				{
					const string __id = "Dimensions.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DiracDelta']"
			[Register("DiracDelta")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DiracDelta
			{
				get
				{
					const string __id = "DiracDelta.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DirectedInfinity']"
			[Register("DirectedInfinity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DirectedInfinity
			{
				get
				{
					const string __id = "DirectedInfinity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Direction']"
			[Register("Direction")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Direction
			{
				get
				{
					const string __id = "Direction.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DiscreteDelta']"
			[Register("DiscreteDelta")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DiscreteDelta
			{
				get
				{
					const string __id = "DiscreteDelta.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DiscreteUniformDistribution']"
			[Register("DiscreteUniformDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DiscreteUniformDistribution
			{
				get
				{
					const string __id = "DiscreteUniformDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Discriminant']"
			[Register("Discriminant")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Discriminant
			{
				get
				{
					const string __id = "Discriminant.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Disputed']"
			[Register("Disputed")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Disputed
			{
				get
				{
					const string __id = "Disputed.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Distribute']"
			[Register("Distribute")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Distribute
			{
				get
				{
					const string __id = "Distribute.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Distributed']"
			[Register("Distributed")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Distributed
			{
				get
				{
					const string __id = "Distributed.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Div']"
			[Register("Div")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Div
			{
				get
				{
					const string __id = "Div.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Divide']"
			[Register("Divide")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Divide
			{
				get
				{
					const string __id = "Divide.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DivideBy']"
			[Register("DivideBy")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DivideBy
			{
				get
				{
					const string __id = "DivideBy.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Divisible']"
			[Register("Divisible")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Divisible
			{
				get
				{
					const string __id = "Divisible.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='DivisorSigma']"
			[Register("DivisorSigma")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol DivisorSigma
			{
				get
				{
					const string __id = "DivisorSigma.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Divisors']"
			[Register("Divisors")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Divisors
			{
				get
				{
					const string __id = "Divisors.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Do']"
			[Register("Do")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Do
			{
				get
				{
					const string __id = "Do.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Dot']"
			[Register("Dot")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Dot
			{
				get
				{
					const string __id = "Dot.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Drop']"
			[Register("Drop")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Drop
			{
				get
				{
					const string __id = "Drop.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='E']"
			[Register("E")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol E
			{
				get
				{
					const string __id = "E.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EasterSunday']"
			[Register("EasterSunday")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EasterSunday
			{
				get
				{
					const string __id = "EasterSunday.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EffectiveInterest']"
			[Register("EffectiveInterest")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EffectiveInterest
			{
				get
				{
					const string __id = "EffectiveInterest.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Eigenvalues']"
			[Register("Eigenvalues")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Eigenvalues
			{
				get
				{
					const string __id = "Eigenvalues.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Eigenvectors']"
			[Register("Eigenvectors")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Eigenvectors
			{
				get
				{
					const string __id = "Eigenvectors.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Element']"
			[Register("Element")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Element
			{
				get
				{
					const string __id = "Element.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ElementData']"
			[Register("ElementData")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ElementData
			{
				get
				{
					const string __id = "ElementData.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Eliminate']"
			[Register("Eliminate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Eliminate
			{
				get
				{
					const string __id = "Eliminate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EllipticE']"
			[Register("EllipticE")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EllipticE
			{
				get
				{
					const string __id = "EllipticE.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EllipticF']"
			[Register("EllipticF")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EllipticF
			{
				get
				{
					const string __id = "EllipticF.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EllipticK']"
			[Register("EllipticK")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EllipticK
			{
				get
				{
					const string __id = "EllipticK.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EllipticPi']"
			[Register("EllipticPi")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EllipticPi
			{
				get
				{
					const string __id = "EllipticPi.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='End']"
			[Register("End")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol End
			{
				get
				{
					const string __id = "End.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EndPackage']"
			[Register("EndPackage")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EndPackage
			{
				get
				{
					const string __id = "EndPackage.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Equal']"
			[Register("Equal")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Equal
			{
				get
				{
					const string __id = "Equal.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Equivalent']"
			[Register("Equivalent")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Equivalent
			{
				get
				{
					const string __id = "Equivalent.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Erf']"
			[Register("Erf")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Erf
			{
				get
				{
					const string __id = "Erf.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Erfc']"
			[Register("Erfc")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Erfc
			{
				get
				{
					const string __id = "Erfc.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Erfi']"
			[Register("Erfi")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Erfi
			{
				get
				{
					const string __id = "Erfi.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ErlangDistribution']"
			[Register("ErlangDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ErlangDistribution
			{
				get
				{
					const string __id = "ErlangDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EuclideanDistance']"
			[Register("EuclideanDistance")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EuclideanDistance
			{
				get
				{
					const string __id = "EuclideanDistance.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EulerE']"
			[Register("EulerE")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EulerE
			{
				get
				{
					const string __id = "EulerE.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EulerGamma']"
			[Register("EulerGamma")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EulerGamma
			{
				get
				{
					const string __id = "EulerGamma.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EulerPhi']"
			[Register("EulerPhi")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EulerPhi
			{
				get
				{
					const string __id = "EulerPhi.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Evaluate']"
			[Register("Evaluate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Evaluate
			{
				get
				{
					const string __id = "Evaluate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='EvenQ']"
			[Register("EvenQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol EvenQ
			{
				get
				{
					const string __id = "EvenQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ExactNumberQ']"
			[Register("ExactNumberQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ExactNumberQ
			{
				get
				{
					const string __id = "ExactNumberQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Except']"
			[Register("Except")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Except
			{
				get
				{
					const string __id = "Except.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Exists']"
			[Register("Exists")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Exists
			{
				get
				{
					const string __id = "Exists.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Exp']"
			[Register("Exp")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Exp
			{
				get
				{
					const string __id = "Exp.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ExpIntegralE']"
			[Register("ExpIntegralE")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ExpIntegralE
			{
				get
				{
					const string __id = "ExpIntegralE.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ExpIntegralEi']"
			[Register("ExpIntegralEi")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ExpIntegralEi
			{
				get
				{
					const string __id = "ExpIntegralEi.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ExpToTrig']"
			[Register("ExpToTrig")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ExpToTrig
			{
				get
				{
					const string __id = "ExpToTrig.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Expand']"
			[Register("Expand")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Expand
			{
				get
				{
					const string __id = "Expand.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ExpandAll']"
			[Register("ExpandAll")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ExpandAll
			{
				get
				{
					const string __id = "ExpandAll.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Expectation']"
			[Register("Expectation")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Expectation
			{
				get
				{
					const string __id = "Expectation.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Exponent']"
			[Register("Exponent")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Exponent
			{
				get
				{
					const string __id = "Exponent.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ExponentialDistribution']"
			[Register("ExponentialDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ExponentialDistribution
			{
				get
				{
					const string __id = "ExponentialDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Export']"
			[Register("Export")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Export
			{
				get
				{
					const string __id = "Export.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ExtendedGCD']"
			[Register("ExtendedGCD")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ExtendedGCD
			{
				get
				{
					const string __id = "ExtendedGCD.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Extract']"
			[Register("Extract")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Extract
			{
				get
				{
					const string __id = "Extract.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FRatioDistribution']"
			[Register("FRatioDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FRatioDistribution
			{
				get
				{
					const string __id = "FRatioDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Factor']"
			[Register("Factor")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Factor
			{
				get
				{
					const string __id = "Factor.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FactorInteger']"
			[Register("FactorInteger")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FactorInteger
			{
				get
				{
					const string __id = "FactorInteger.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FactorSquareFree']"
			[Register("FactorSquareFree")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FactorSquareFree
			{
				get
				{
					const string __id = "FactorSquareFree.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FactorSquareFreeList']"
			[Register("FactorSquareFreeList")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FactorSquareFreeList
			{
				get
				{
					const string __id = "FactorSquareFreeList.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FactorTerms']"
			[Register("FactorTerms")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FactorTerms
			{
				get
				{
					const string __id = "FactorTerms.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Factorial']"
			[Register("Factorial")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Factorial
			{
				get
				{
					const string __id = "Factorial.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Factorial2']"
			[Register("Factorial2")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Factorial2
			{
				get
				{
					const string __id = "Factorial2.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='False']"
			[Register("False")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol False
			{
				get
				{
					const string __id = "False.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Fibonacci']"
			[Register("Fibonacci")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Fibonacci
			{
				get
				{
					const string __id = "Fibonacci.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FindFit']"
			[Register("FindFit")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FindFit
			{
				get
				{
					const string __id = "FindFit.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FindInstance']"
			[Register("FindInstance")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FindInstance
			{
				get
				{
					const string __id = "FindInstance.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FindRoot']"
			[Register("FindRoot")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FindRoot
			{
				get
				{
					const string __id = "FindRoot.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='First']"
			[Register("First")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol First
			{
				get
				{
					const string __id = "First.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Fit']"
			[Register("Fit")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Fit
			{
				get
				{
					const string __id = "Fit.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FiveNum']"
			[Register("FiveNum")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FiveNum
			{
				get
				{
					const string __id = "FiveNum.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FixedPoint']"
			[Register("FixedPoint")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FixedPoint
			{
				get
				{
					const string __id = "FixedPoint.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FixedPointList']"
			[Register("FixedPointList")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FixedPointList
			{
				get
				{
					const string __id = "FixedPointList.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Flat']"
			[Register("Flat")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Flat
			{
				get
				{
					const string __id = "Flat.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Flatten']"
			[Register("Flatten")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Flatten
			{
				get
				{
					const string __id = "Flatten.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FlattenAt']"
			[Register("FlattenAt")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FlattenAt
			{
				get
				{
					const string __id = "FlattenAt.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Floor']"
			[Register("Floor")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Floor
			{
				get
				{
					const string __id = "Floor.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Fold']"
			[Register("Fold")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Fold
			{
				get
				{
					const string __id = "Fold.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FoldList']"
			[Register("FoldList")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FoldList
			{
				get
				{
					const string __id = "FoldList.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='For']"
			[Register("For")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol For
			{
				get
				{
					const string __id = "For.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ForAll']"
			[Register("ForAll")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ForAll
			{
				get
				{
					const string __id = "ForAll.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FourierMatrix']"
			[Register("FourierMatrix")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FourierMatrix
			{
				get
				{
					const string __id = "FourierMatrix.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FractionalPart']"
			[Register("FractionalPart")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FractionalPart
			{
				get
				{
					const string __id = "FractionalPart.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FrechetDistribution']"
			[Register("FrechetDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FrechetDistribution
			{
				get
				{
					const string __id = "FrechetDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FreeQ']"
			[Register("FreeQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FreeQ
			{
				get
				{
					const string __id = "FreeQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FresnelC']"
			[Register("FresnelC")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FresnelC
			{
				get
				{
					const string __id = "FresnelC.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FresnelS']"
			[Register("FresnelS")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FresnelS
			{
				get
				{
					const string __id = "FresnelS.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FrobeniusNumber']"
			[Register("FrobeniusNumber")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FrobeniusNumber
			{
				get
				{
					const string __id = "FrobeniusNumber.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FrobeniusSolve']"
			[Register("FrobeniusSolve")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FrobeniusSolve
			{
				get
				{
					const string __id = "FrobeniusSolve.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FromCharacterCode']"
			[Register("FromCharacterCode")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FromCharacterCode
			{
				get
				{
					const string __id = "FromCharacterCode.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FromContinuedFraction']"
			[Register("FromContinuedFraction")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FromContinuedFraction
			{
				get
				{
					const string __id = "FromContinuedFraction.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FromDigits']"
			[Register("FromDigits")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FromDigits
			{
				get
				{
					const string __id = "FromDigits.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FromPolarCoordinates']"
			[Register("FromPolarCoordinates")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FromPolarCoordinates
			{
				get
				{
					const string __id = "FromPolarCoordinates.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FullForm']"
			[Register("FullForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FullForm
			{
				get
				{
					const string __id = "FullForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FullSimplify']"
			[Register("FullSimplify")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FullSimplify
			{
				get
				{
					const string __id = "FullSimplify.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Function']"
			[Register("Function")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Function
			{
				get
				{
					const string __id = "Function.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='FunctionExpand']"
			[Register("FunctionExpand")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol FunctionExpand
			{
				get
				{
					const string __id = "FunctionExpand.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='GCD']"
			[Register("GCD")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol GCD
			{
				get
				{
					const string __id = "GCD.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Gamma']"
			[Register("Gamma")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Gamma
			{
				get
				{
					const string __id = "Gamma.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='GammaDistribution']"
			[Register("GammaDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol GammaDistribution
			{
				get
				{
					const string __id = "GammaDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='GammaRegularized']"
			[Register("GammaRegularized")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol GammaRegularized
			{
				get
				{
					const string __id = "GammaRegularized.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Gather']"
			[Register("Gather")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Gather
			{
				get
				{
					const string __id = "Gather.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='GegenbauerC']"
			[Register("GegenbauerC")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol GegenbauerC
			{
				get
				{
					const string __id = "GegenbauerC.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='GeometricDistribution']"
			[Register("GeometricDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol GeometricDistribution
			{
				get
				{
					const string __id = "GeometricDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='GeometricMean']"
			[Register("GeometricMean")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol GeometricMean
			{
				get
				{
					const string __id = "GeometricMean.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Get']"
			[Register("Get")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Get
			{
				get
				{
					const string __id = "Get.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Glaisher']"
			[Register("Glaisher")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Glaisher
			{
				get
				{
					const string __id = "Glaisher.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='GoldenRatio']"
			[Register("GoldenRatio")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol GoldenRatio
			{
				get
				{
					const string __id = "GoldenRatio.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Grad']"
			[Register("Grad")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Grad
			{
				get
				{
					const string __id = "Grad.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Graphics']"
			[Register("Graphics")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Graphics
			{
				get
				{
					const string __id = "Graphics.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Graphics3D']"
			[Register("Graphics3D")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Graphics3D
			{
				get
				{
					const string __id = "Graphics3D.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Greater']"
			[Register("Greater")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Greater
			{
				get
				{
					const string __id = "Greater.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='GreaterEqual']"
			[Register("GreaterEqual")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol GreaterEqual
			{
				get
				{
					const string __id = "GreaterEqual.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='GroebnerBasis']"
			[Register("GroebnerBasis")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol GroebnerBasis
			{
				get
				{
					const string __id = "GroebnerBasis.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='GumbelDistribution']"
			[Register("GumbelDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol GumbelDistribution
			{
				get
				{
					const string __id = "GumbelDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HarmonicNumber']"
			[Register("HarmonicNumber")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HarmonicNumber
			{
				get
				{
					const string __id = "HarmonicNumber.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Haversine']"
			[Register("Haversine")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Haversine
			{
				get
				{
					const string __id = "Haversine.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Head']"
			[Register("Head")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Head
			{
				get
				{
					const string __id = "Head.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HeavisideTheta']"
			[Register("HeavisideTheta")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HeavisideTheta
			{
				get
				{
					const string __id = "HeavisideTheta.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HermiteH']"
			[Register("HermiteH")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HermiteH
			{
				get
				{
					const string __id = "HermiteH.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HermitianMatrixQ']"
			[Register("HermitianMatrixQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HermitianMatrixQ
			{
				get
				{
					const string __id = "HermitianMatrixQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HilbertMatrix']"
			[Register("HilbertMatrix")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HilbertMatrix
			{
				get
				{
					const string __id = "HilbertMatrix.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Hold']"
			[Register("Hold")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Hold
			{
				get
				{
					const string __id = "Hold.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HoldAll']"
			[Register("HoldAll")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HoldAll
			{
				get
				{
					const string __id = "HoldAll.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HoldFirst']"
			[Register("HoldFirst")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HoldFirst
			{
				get
				{
					const string __id = "HoldFirst.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HoldForm']"
			[Register("HoldForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HoldForm
			{
				get
				{
					const string __id = "HoldForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HoldPattern']"
			[Register("HoldPattern")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HoldPattern
			{
				get
				{
					const string __id = "HoldPattern.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HoldRest']"
			[Register("HoldRest")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HoldRest
			{
				get
				{
					const string __id = "HoldRest.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Horner']"
			[Register("Horner")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Horner
			{
				get
				{
					const string __id = "Horner.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HornerForm']"
			[Register("HornerForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HornerForm
			{
				get
				{
					const string __id = "HornerForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HurwitzZeta']"
			[Register("HurwitzZeta")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HurwitzZeta
			{
				get
				{
					const string __id = "HurwitzZeta.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Hypergeometric0F1']"
			[Register("Hypergeometric0F1")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Hypergeometric0F1
			{
				get
				{
					const string __id = "Hypergeometric0F1.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Hypergeometric1F1']"
			[Register("Hypergeometric1F1")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Hypergeometric1F1
			{
				get
				{
					const string __id = "Hypergeometric1F1.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Hypergeometric2F1']"
			[Register("Hypergeometric2F1")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Hypergeometric2F1
			{
				get
				{
					const string __id = "Hypergeometric2F1.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HypergeometricDistribution']"
			[Register("HypergeometricDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HypergeometricDistribution
			{
				get
				{
					const string __id = "HypergeometricDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HypergeometricPFQ']"
			[Register("HypergeometricPFQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HypergeometricPFQ
			{
				get
				{
					const string __id = "HypergeometricPFQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='HypergeometricPFQRegularized']"
			[Register("HypergeometricPFQRegularized")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol HypergeometricPFQRegularized
			{
				get
				{
					const string __id = "HypergeometricPFQRegularized.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='I']"
			[Register("I")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol I
			{
				get
				{
					const string __id = "I.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Identity']"
			[Register("Identity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Identity
			{
				get
				{
					const string __id = "Identity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='IdentityMatrix']"
			[Register("IdentityMatrix")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol IdentityMatrix
			{
				get
				{
					const string __id = "IdentityMatrix.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='If']"
			[Register("If")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol If
			{
				get
				{
					const string __id = "If.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Im']"
			[Register("Im")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Im
			{
				get
				{
					const string __id = "Im.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Implies']"
			[Register("Implies")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Implies
			{
				get
				{
					const string __id = "Implies.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Import']"
			[Register("Import")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Import
			{
				get
				{
					const string __id = "Import.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Increment']"
			[Register("Increment")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Increment
			{
				get
				{
					const string __id = "Increment.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Indeterminate']"
			[Register("Indeterminate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Indeterminate
			{
				get
				{
					const string __id = "Indeterminate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Inequality']"
			[Register("Inequality")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Inequality
			{
				get
				{
					const string __id = "Inequality.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InexactNumberQ']"
			[Register("InexactNumberQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InexactNumberQ
			{
				get
				{
					const string __id = "InexactNumberQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Infinity']"
			[Register("Infinity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Infinity
			{
				get
				{
					const string __id = "Infinity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Information']"
			[Register("Information")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Information
			{
				get
				{
					const string __id = "Information.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Inner']"
			[Register("Inner")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Inner
			{
				get
				{
					const string __id = "Inner.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InputForm']"
			[Register("InputForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InputForm
			{
				get
				{
					const string __id = "InputForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Insert']"
			[Register("Insert")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Insert
			{
				get
				{
					const string __id = "Insert.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Integer']"
			[Register("Integer")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Integer
			{
				get
				{
					const string __id = "Integer.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='IntegerDigits']"
			[Register("IntegerDigits")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol IntegerDigits
			{
				get
				{
					const string __id = "IntegerDigits.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='IntegerExponent']"
			[Register("IntegerExponent")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol IntegerExponent
			{
				get
				{
					const string __id = "IntegerExponent.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='IntegerLength']"
			[Register("IntegerLength")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol IntegerLength
			{
				get
				{
					const string __id = "IntegerLength.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='IntegerPart']"
			[Register("IntegerPart")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol IntegerPart
			{
				get
				{
					const string __id = "IntegerPart.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='IntegerPartitions']"
			[Register("IntegerPartitions")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol IntegerPartitions
			{
				get
				{
					const string __id = "IntegerPartitions.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='IntegerQ']"
			[Register("IntegerQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol IntegerQ
			{
				get
				{
					const string __id = "IntegerQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Integers']"
			[Register("Integers")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Integers
			{
				get
				{
					const string __id = "Integers.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Integrate']"
			[Register("Integrate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Integrate
			{
				get
				{
					const string __id = "Integrate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InterpolatingFunction']"
			[Register("InterpolatingFunction")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InterpolatingFunction
			{
				get
				{
					const string __id = "InterpolatingFunction.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InterpolatingPolynomial']"
			[Register("InterpolatingPolynomial")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InterpolatingPolynomial
			{
				get
				{
					const string __id = "InterpolatingPolynomial.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Interpolation']"
			[Register("Interpolation")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Interpolation
			{
				get
				{
					const string __id = "Interpolation.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Intersection']"
			[Register("Intersection")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Intersection
			{
				get
				{
					const string __id = "Intersection.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Interval']"
			[Register("Interval")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Interval
			{
				get
				{
					const string __id = "Interval.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Inverse']"
			[Register("Inverse")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Inverse
			{
				get
				{
					const string __id = "Inverse.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InverseBetaRegularized']"
			[Register("InverseBetaRegularized")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InverseBetaRegularized
			{
				get
				{
					const string __id = "InverseBetaRegularized.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InverseErf']"
			[Register("InverseErf")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InverseErf
			{
				get
				{
					const string __id = "InverseErf.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InverseErfc']"
			[Register("InverseErfc")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InverseErfc
			{
				get
				{
					const string __id = "InverseErfc.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InverseFunction']"
			[Register("InverseFunction")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InverseFunction
			{
				get
				{
					const string __id = "InverseFunction.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InverseGammaRegularized']"
			[Register("InverseGammaRegularized")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InverseGammaRegularized
			{
				get
				{
					const string __id = "InverseGammaRegularized.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InverseHaversine']"
			[Register("InverseHaversine")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InverseHaversine
			{
				get
				{
					const string __id = "InverseHaversine.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InverseLaplaceTransform']"
			[Register("InverseLaplaceTransform")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InverseLaplaceTransform
			{
				get
				{
					const string __id = "InverseLaplaceTransform.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='InverseSeries']"
			[Register("InverseSeries")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol InverseSeries
			{
				get
				{
					const string __id = "InverseSeries.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='JaccardDissimilarity']"
			[Register("JaccardDissimilarity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol JaccardDissimilarity
			{
				get
				{
					const string __id = "JaccardDissimilarity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='JacobiMatrix']"
			[Register("JacobiMatrix")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol JacobiMatrix
			{
				get
				{
					const string __id = "JacobiMatrix.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='JacobiSymbol']"
			[Register("JacobiSymbol")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol JacobiSymbol
			{
				get
				{
					const string __id = "JacobiSymbol.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='JacobiZeta']"
			[Register("JacobiZeta")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol JacobiZeta
			{
				get
				{
					const string __id = "JacobiZeta.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='JavaForm']"
			[Register("JavaForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol JavaForm
			{
				get
				{
					const string __id = "JavaForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Join']"
			[Register("Join")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Join
			{
				get
				{
					const string __id = "Join.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='KOrderlessPartitions']"
			[Register("KOrderlessPartitions")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol KOrderlessPartitions
			{
				get
				{
					const string __id = "KOrderlessPartitions.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='KPartitions']"
			[Register("KPartitions")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol KPartitions
			{
				get
				{
					const string __id = "KPartitions.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Khinchin']"
			[Register("Khinchin")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Khinchin
			{
				get
				{
					const string __id = "Khinchin.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='KnownUnitQ']"
			[Register("KnownUnitQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol KnownUnitQ
			{
				get
				{
					const string __id = "KnownUnitQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='KolmogorovSmirnovTest']"
			[Register("KolmogorovSmirnovTest")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol KolmogorovSmirnovTest
			{
				get
				{
					const string __id = "KolmogorovSmirnovTest.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='KroneckerDelta']"
			[Register("KroneckerDelta")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol KroneckerDelta
			{
				get
				{
					const string __id = "KroneckerDelta.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Kurtosis']"
			[Register("Kurtosis")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Kurtosis
			{
				get
				{
					const string __id = "Kurtosis.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LCM']"
			[Register("LCM")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LCM
			{
				get
				{
					const string __id = "LCM.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LUDecomposition']"
			[Register("LUDecomposition")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LUDecomposition
			{
				get
				{
					const string __id = "LUDecomposition.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LaguerreL']"
			[Register("LaguerreL")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LaguerreL
			{
				get
				{
					const string __id = "LaguerreL.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LaplaceTransform']"
			[Register("LaplaceTransform")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LaplaceTransform
			{
				get
				{
					const string __id = "LaplaceTransform.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Last']"
			[Register("Last")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Last
			{
				get
				{
					const string __id = "Last.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LeafCount']"
			[Register("LeafCount")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LeafCount
			{
				get
				{
					const string __id = "LeafCount.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LeastSquares']"
			[Register("LeastSquares")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LeastSquares
			{
				get
				{
					const string __id = "LeastSquares.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LegendreP']"
			[Register("LegendreP")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LegendreP
			{
				get
				{
					const string __id = "LegendreP.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LegendreQ']"
			[Register("LegendreQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LegendreQ
			{
				get
				{
					const string __id = "LegendreQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Length']"
			[Register("Length")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Length
			{
				get
				{
					const string __id = "Length.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Less']"
			[Register("Less")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Less
			{
				get
				{
					const string __id = "Less.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LessEqual']"
			[Register("LessEqual")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LessEqual
			{
				get
				{
					const string __id = "LessEqual.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LetterQ']"
			[Register("LetterQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LetterQ
			{
				get
				{
					const string __id = "LetterQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Level']"
			[Register("Level")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Level
			{
				get
				{
					const string __id = "Level.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LevelQ']"
			[Register("LevelQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LevelQ
			{
				get
				{
					const string __id = "LevelQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Limit']"
			[Register("Limit")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Limit
			{
				get
				{
					const string __id = "Limit.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Line']"
			[Register("Line")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Line
			{
				get
				{
					const string __id = "Line.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LinearModelFit']"
			[Register("LinearModelFit")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LinearModelFit
			{
				get
				{
					const string __id = "LinearModelFit.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LinearProgramming']"
			[Register("LinearProgramming")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LinearProgramming
			{
				get
				{
					const string __id = "LinearProgramming.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LinearRecurrence']"
			[Register("LinearRecurrence")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LinearRecurrence
			{
				get
				{
					const string __id = "LinearRecurrence.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LinearSolve']"
			[Register("LinearSolve")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LinearSolve
			{
				get
				{
					const string __id = "LinearSolve.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LiouvilleLambda']"
			[Register("LiouvilleLambda")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LiouvilleLambda
			{
				get
				{
					const string __id = "LiouvilleLambda.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='List']"
			[Register("List")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol List
			{
				get
				{
					const string __id = "List.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ListConvolve']"
			[Register("ListConvolve")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ListConvolve
			{
				get
				{
					const string __id = "ListConvolve.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ListCorrelate']"
			[Register("ListCorrelate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ListCorrelate
			{
				get
				{
					const string __id = "ListCorrelate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ListQ']"
			[Register("ListQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ListQ
			{
				get
				{
					const string __id = "ListQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Listable']"
			[Register("Listable")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Listable
			{
				get
				{
					const string __id = "Listable.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Literal']"
			[Register("Literal")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Literal
			{
				get
				{
					const string __id = "Literal.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Log']"
			[Register("Log")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Log
			{
				get
				{
					const string __id = "Log.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Log10']"
			[Register("Log10")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Log10
			{
				get
				{
					const string __id = "Log10.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Log2']"
			[Register("Log2")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Log2
			{
				get
				{
					const string __id = "Log2.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LogGamma']"
			[Register("LogGamma")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LogGamma
			{
				get
				{
					const string __id = "LogGamma.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LogIntegral']"
			[Register("LogIntegral")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LogIntegral
			{
				get
				{
					const string __id = "LogIntegral.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LogNormalDistribution']"
			[Register("LogNormalDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LogNormalDistribution
			{
				get
				{
					const string __id = "LogNormalDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LogicalExpand']"
			[Register("LogicalExpand")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LogicalExpand
			{
				get
				{
					const string __id = "LogicalExpand.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LogisticSigmoid']"
			[Register("LogisticSigmoid")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LogisticSigmoid
			{
				get
				{
					const string __id = "LogisticSigmoid.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LowerCaseQ']"
			[Register("LowerCaseQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LowerCaseQ
			{
				get
				{
					const string __id = "LowerCaseQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LowerTriangularize']"
			[Register("LowerTriangularize")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LowerTriangularize
			{
				get
				{
					const string __id = "LowerTriangularize.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='LucasL']"
			[Register("LucasL")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol LucasL
			{
				get
				{
					const string __id = "LucasL.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MachineNumberQ']"
			[Register("MachineNumberQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MachineNumberQ
			{
				get
				{
					const string __id = "MachineNumberQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MangoldtLambda']"
			[Register("MangoldtLambda")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MangoldtLambda
			{
				get
				{
					const string __id = "MangoldtLambda.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ManhattanDistance']"
			[Register("ManhattanDistance")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ManhattanDistance
			{
				get
				{
					const string __id = "ManhattanDistance.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MantissaExponent']"
			[Register("MantissaExponent")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MantissaExponent
			{
				get
				{
					const string __id = "MantissaExponent.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Map']"
			[Register("Map")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Map
			{
				get
				{
					const string __id = "Map.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MapAll']"
			[Register("MapAll")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MapAll
			{
				get
				{
					const string __id = "MapAll.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MapAt']"
			[Register("MapAt")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MapAt
			{
				get
				{
					const string __id = "MapAt.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MapIndexed']"
			[Register("MapIndexed")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MapIndexed
			{
				get
				{
					const string __id = "MapIndexed.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MapThread']"
			[Register("MapThread")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MapThread
			{
				get
				{
					const string __id = "MapThread.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MatchQ']"
			[Register("MatchQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MatchQ
			{
				get
				{
					const string __id = "MatchQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MatchingDissimilarity']"
			[Register("MatchingDissimilarity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MatchingDissimilarity
			{
				get
				{
					const string __id = "MatchingDissimilarity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MathMLForm']"
			[Register("MathMLForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MathMLForm
			{
				get
				{
					const string __id = "MathMLForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MatrixForm']"
			[Register("MatrixForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MatrixForm
			{
				get
				{
					const string __id = "MatrixForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MatrixMinimalPolynomial']"
			[Register("MatrixMinimalPolynomial")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MatrixMinimalPolynomial
			{
				get
				{
					const string __id = "MatrixMinimalPolynomial.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MatrixPower']"
			[Register("MatrixPower")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MatrixPower
			{
				get
				{
					const string __id = "MatrixPower.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MatrixQ']"
			[Register("MatrixQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MatrixQ
			{
				get
				{
					const string __id = "MatrixQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MatrixRank']"
			[Register("MatrixRank")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MatrixRank
			{
				get
				{
					const string __id = "MatrixRank.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Max']"
			[Register("Max")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Max
			{
				get
				{
					const string __id = "Max.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MaxIterations']"
			[Register("MaxIterations")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MaxIterations
			{
				get
				{
					const string __id = "MaxIterations.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MaxPoints']"
			[Register("MaxPoints")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MaxPoints
			{
				get
				{
					const string __id = "MaxPoints.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Mean']"
			[Register("Mean")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Mean
			{
				get
				{
					const string __id = "Mean.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MeanDeviation']"
			[Register("MeanDeviation")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MeanDeviation
			{
				get
				{
					const string __id = "MeanDeviation.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Median']"
			[Register("Median")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Median
			{
				get
				{
					const string __id = "Median.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MeijerG']"
			[Register("MeijerG")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MeijerG
			{
				get
				{
					const string __id = "MeijerG.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MemberQ']"
			[Register("MemberQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MemberQ
			{
				get
				{
					const string __id = "MemberQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MersennePrimeExponent']"
			[Register("MersennePrimeExponent")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MersennePrimeExponent
			{
				get
				{
					const string __id = "MersennePrimeExponent.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MersennePrimeExponentQ']"
			[Register("MersennePrimeExponentQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MersennePrimeExponentQ
			{
				get
				{
					const string __id = "MersennePrimeExponentQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MeshRange']"
			[Register("MeshRange")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MeshRange
			{
				get
				{
					const string __id = "MeshRange.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MessageName']"
			[Register("MessageName")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MessageName
			{
				get
				{
					const string __id = "MessageName.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Method']"
			[Register("Method")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Method
			{
				get
				{
					const string __id = "Method.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Min']"
			[Register("Min")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Min
			{
				get
				{
					const string __id = "Min.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MinimalPolynomial']"
			[Register("MinimalPolynomial")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MinimalPolynomial
			{
				get
				{
					const string __id = "MinimalPolynomial.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Minus']"
			[Register("Minus")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Minus
			{
				get
				{
					const string __id = "Minus.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Missing']"
			[Register("Missing")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Missing
			{
				get
				{
					const string __id = "Missing.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MissingQ']"
			[Register("MissingQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MissingQ
			{
				get
				{
					const string __id = "MissingQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Mod']"
			[Register("Mod")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Mod
			{
				get
				{
					const string __id = "Mod.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Module']"
			[Register("Module")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Module
			{
				get
				{
					const string __id = "Module.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Modulus']"
			[Register("Modulus")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Modulus
			{
				get
				{
					const string __id = "Modulus.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MoebiusMu']"
			[Register("MoebiusMu")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MoebiusMu
			{
				get
				{
					const string __id = "MoebiusMu.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MonomialList']"
			[Register("MonomialList")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MonomialList
			{
				get
				{
					const string __id = "MonomialList.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Most']"
			[Register("Most")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Most
			{
				get
				{
					const string __id = "Most.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Multinomial']"
			[Register("Multinomial")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Multinomial
			{
				get
				{
					const string __id = "Multinomial.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='MultiplicativeOrder']"
			[Register("MultiplicativeOrder")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol MultiplicativeOrder
			{
				get
				{
					const string __id = "MultiplicativeOrder.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='N']"
			[Register("N")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol N
			{
				get
				{
					const string __id = "N.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NDSolve']"
			[Register("NDSolve")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NDSolve
			{
				get
				{
					const string __id = "NDSolve.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NFourierTransform']"
			[Register("NFourierTransform")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NFourierTransform
			{
				get
				{
					const string __id = "NFourierTransform.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NHoldAll']"
			[Register("NHoldAll")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NHoldAll
			{
				get
				{
					const string __id = "NHoldAll.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NHoldFirst']"
			[Register("NHoldFirst")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NHoldFirst
			{
				get
				{
					const string __id = "NHoldFirst.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NHoldRest']"
			[Register("NHoldRest")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NHoldRest
			{
				get
				{
					const string __id = "NHoldRest.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NIntegrate']"
			[Register("NIntegrate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NIntegrate
			{
				get
				{
					const string __id = "NIntegrate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NMaximize']"
			[Register("NMaximize")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NMaximize
			{
				get
				{
					const string __id = "NMaximize.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NMinimize']"
			[Register("NMinimize")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NMinimize
			{
				get
				{
					const string __id = "NMinimize.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NRoots']"
			[Register("NRoots")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NRoots
			{
				get
				{
					const string __id = "NRoots.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NSolve']"
			[Register("NSolve")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NSolve
			{
				get
				{
					const string __id = "NSolve.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NakagamiDistribution']"
			[Register("NakagamiDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NakagamiDistribution
			{
				get
				{
					const string __id = "NakagamiDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Names']"
			[Register("Names")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Names
			{
				get
				{
					const string __id = "Names.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Nand']"
			[Register("Nand")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Nand
			{
				get
				{
					const string __id = "Nand.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Nearest']"
			[Register("Nearest")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Nearest
			{
				get
				{
					const string __id = "Nearest.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Negative']"
			[Register("Negative")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Negative
			{
				get
				{
					const string __id = "Negative.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Nest']"
			[Register("Nest")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Nest
			{
				get
				{
					const string __id = "Nest.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NestList']"
			[Register("NestList")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NestList
			{
				get
				{
					const string __id = "NestList.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NestWhile']"
			[Register("NestWhile")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NestWhile
			{
				get
				{
					const string __id = "NestWhile.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NestWhileList']"
			[Register("NestWhileList")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NestWhileList
			{
				get
				{
					const string __id = "NestWhileList.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NextPrime']"
			[Register("NextPrime")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NextPrime
			{
				get
				{
					const string __id = "NextPrime.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NonCommutativeMultiply']"
			[Register("NonCommutativeMultiply")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NonCommutativeMultiply
			{
				get
				{
					const string __id = "NonCommutativeMultiply.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NonNegative']"
			[Register("NonNegative")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NonNegative
			{
				get
				{
					const string __id = "NonNegative.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NonPositive']"
			[Register("NonPositive")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NonPositive
			{
				get
				{
					const string __id = "NonPositive.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='None']"
			[Register("None")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol None
			{
				get
				{
					const string __id = "None.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NoneTrue']"
			[Register("NoneTrue")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NoneTrue
			{
				get
				{
					const string __id = "NoneTrue.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Nonexistent']"
			[Register("Nonexistent")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Nonexistent
			{
				get
				{
					const string __id = "Nonexistent.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Nor']"
			[Register("Nor")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Nor
			{
				get
				{
					const string __id = "Nor.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Norm']"
			[Register("Norm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Norm
			{
				get
				{
					const string __id = "Norm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Normal']"
			[Register("Normal")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Normal
			{
				get
				{
					const string __id = "Normal.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NormalDistribution']"
			[Register("NormalDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NormalDistribution
			{
				get
				{
					const string __id = "NormalDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Normalize']"
			[Register("Normalize")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Normalize
			{
				get
				{
					const string __id = "Normalize.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Not']"
			[Register("Not")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Not
			{
				get
				{
					const string __id = "Not.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NotApplicable']"
			[Register("NotApplicable")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NotApplicable
			{
				get
				{
					const string __id = "NotApplicable.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NotAvailable']"
			[Register("NotAvailable")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NotAvailable
			{
				get
				{
					const string __id = "NotAvailable.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NotElement']"
			[Register("NotElement")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NotElement
			{
				get
				{
					const string __id = "NotElement.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NotListQ']"
			[Register("NotListQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NotListQ
			{
				get
				{
					const string __id = "NotListQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Null']"
			[Register("Null")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Null
			{
				get
				{
					const string __id = "Null.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NullSpace']"
			[Register("NullSpace")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NullSpace
			{
				get
				{
					const string __id = "NullSpace.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NumberFieldRootsOfUnity']"
			[Register("NumberFieldRootsOfUnity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NumberFieldRootsOfUnity
			{
				get
				{
					const string __id = "NumberFieldRootsOfUnity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NumberQ']"
			[Register("NumberQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NumberQ
			{
				get
				{
					const string __id = "NumberQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Numerator']"
			[Register("Numerator")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Numerator
			{
				get
				{
					const string __id = "Numerator.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NumericFunction']"
			[Register("NumericFunction")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NumericFunction
			{
				get
				{
					const string __id = "NumericFunction.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='NumericQ']"
			[Register("NumericQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol NumericQ
			{
				get
				{
					const string __id = "NumericQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='O']"
			[Register("O")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol O
			{
				get
				{
					const string __id = "O.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='OddQ']"
			[Register("OddQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol OddQ
			{
				get
				{
					const string __id = "OddQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='OneIdentity']"
			[Register("OneIdentity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol OneIdentity
			{
				get
				{
					const string __id = "OneIdentity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Operate']"
			[Register("Operate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Operate
			{
				get
				{
					const string __id = "Operate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='OptimizeExpression']"
			[Register("OptimizeExpression")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol OptimizeExpression
			{
				get
				{
					const string __id = "OptimizeExpression.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Optional']"
			[Register("Optional")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Optional
			{
				get
				{
					const string __id = "Optional.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Options']"
			[Register("Options")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Options
			{
				get
				{
					const string __id = "Options.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Or']"
			[Register("Or")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Or
			{
				get
				{
					const string __id = "Or.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Order']"
			[Register("Order")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Order
			{
				get
				{
					const string __id = "Order.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='OrderedQ']"
			[Register("OrderedQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol OrderedQ
			{
				get
				{
					const string __id = "OrderedQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Ordering']"
			[Register("Ordering")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Ordering
			{
				get
				{
					const string __id = "Ordering.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Orderless']"
			[Register("Orderless")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Orderless
			{
				get
				{
					const string __id = "Orderless.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='OrthogonalMatrixQ']"
			[Register("OrthogonalMatrixQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol OrthogonalMatrixQ
			{
				get
				{
					const string __id = "OrthogonalMatrixQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Orthogonalize']"
			[Register("Orthogonalize")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Orthogonalize
			{
				get
				{
					const string __id = "Orthogonalize.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Out']"
			[Register("Out")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Out
			{
				get
				{
					const string __id = "Out.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Outer']"
			[Register("Outer")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Outer
			{
				get
				{
					const string __id = "Outer.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='OutputForm']"
			[Register("OutputForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol OutputForm
			{
				get
				{
					const string __id = "OutputForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PDF']"
			[Register("PDF")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PDF
			{
				get
				{
					const string __id = "PDF.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Package']"
			[Register("Package")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Package
			{
				get
				{
					const string __id = "Package.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PadLeft']"
			[Register("PadLeft")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PadLeft
			{
				get
				{
					const string __id = "PadLeft.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PadRight']"
			[Register("PadRight")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PadRight
			{
				get
				{
					const string __id = "PadRight.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ParametricPlot']"
			[Register("ParametricPlot")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ParametricPlot
			{
				get
				{
					const string __id = "ParametricPlot.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Part']"
			[Register("Part")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Part
			{
				get
				{
					const string __id = "Part.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Partition']"
			[Register("Partition")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Partition
			{
				get
				{
					const string __id = "Partition.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PartitionsP']"
			[Register("PartitionsP")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PartitionsP
			{
				get
				{
					const string __id = "PartitionsP.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PartitionsQ']"
			[Register("PartitionsQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PartitionsQ
			{
				get
				{
					const string __id = "PartitionsQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Pattern']"
			[Register("Pattern")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Pattern
			{
				get
				{
					const string __id = "Pattern.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PatternTest']"
			[Register("PatternTest")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PatternTest
			{
				get
				{
					const string __id = "PatternTest.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PerfectNumber']"
			[Register("PerfectNumber")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PerfectNumber
			{
				get
				{
					const string __id = "PerfectNumber.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PerfectNumberQ']"
			[Register("PerfectNumberQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PerfectNumberQ
			{
				get
				{
					const string __id = "PerfectNumberQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Permutations']"
			[Register("Permutations")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Permutations
			{
				get
				{
					const string __id = "Permutations.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Pi']"
			[Register("Pi")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Pi
			{
				get
				{
					const string __id = "Pi.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Piecewise']"
			[Register("Piecewise")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Piecewise
			{
				get
				{
					const string __id = "Piecewise.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Plot']"
			[Register("Plot")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Plot
			{
				get
				{
					const string __id = "Plot.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Plot3D']"
			[Register("Plot3D")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Plot3D
			{
				get
				{
					const string __id = "Plot3D.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PlotRange']"
			[Register("PlotRange")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PlotRange
			{
				get
				{
					const string __id = "PlotRange.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Plus']"
			[Register("Plus")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Plus
			{
				get
				{
					const string __id = "Plus.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Pochhammer']"
			[Register("Pochhammer")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Pochhammer
			{
				get
				{
					const string __id = "Pochhammer.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Point']"
			[Register("Point")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Point
			{
				get
				{
					const string __id = "Point.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PoissonDistribution']"
			[Register("PoissonDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PoissonDistribution
			{
				get
				{
					const string __id = "PoissonDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PolyGamma']"
			[Register("PolyGamma")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PolyGamma
			{
				get
				{
					const string __id = "PolyGamma.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PolyLog']"
			[Register("PolyLog")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PolyLog
			{
				get
				{
					const string __id = "PolyLog.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Polygon']"
			[Register("Polygon")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Polygon
			{
				get
				{
					const string __id = "Polygon.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PolynomialExtendedGCD']"
			[Register("PolynomialExtendedGCD")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PolynomialExtendedGCD
			{
				get
				{
					const string __id = "PolynomialExtendedGCD.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PolynomialGCD']"
			[Register("PolynomialGCD")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PolynomialGCD
			{
				get
				{
					const string __id = "PolynomialGCD.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PolynomialLCM']"
			[Register("PolynomialLCM")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PolynomialLCM
			{
				get
				{
					const string __id = "PolynomialLCM.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PolynomialQ']"
			[Register("PolynomialQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PolynomialQ
			{
				get
				{
					const string __id = "PolynomialQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PolynomialQuotient']"
			[Register("PolynomialQuotient")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PolynomialQuotient
			{
				get
				{
					const string __id = "PolynomialQuotient.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PolynomialQuotientRemainder']"
			[Register("PolynomialQuotientRemainder")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PolynomialQuotientRemainder
			{
				get
				{
					const string __id = "PolynomialQuotientRemainder.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PolynomialRemainder']"
			[Register("PolynomialRemainder")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PolynomialRemainder
			{
				get
				{
					const string __id = "PolynomialRemainder.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Position']"
			[Register("Position")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Position
			{
				get
				{
					const string __id = "Position.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Positive']"
			[Register("Positive")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Positive
			{
				get
				{
					const string __id = "Positive.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PossibleZeroQ']"
			[Register("PossibleZeroQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PossibleZeroQ
			{
				get
				{
					const string __id = "PossibleZeroQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Power']"
			[Register("Power")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Power
			{
				get
				{
					const string __id = "Power.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PowerExpand']"
			[Register("PowerExpand")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PowerExpand
			{
				get
				{
					const string __id = "PowerExpand.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PowerMod']"
			[Register("PowerMod")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PowerMod
			{
				get
				{
					const string __id = "PowerMod.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PreDecrement']"
			[Register("PreDecrement")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PreDecrement
			{
				get
				{
					const string __id = "PreDecrement.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PreIncrement']"
			[Register("PreIncrement")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PreIncrement
			{
				get
				{
					const string __id = "PreIncrement.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PrePlus']"
			[Register("PrePlus")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PrePlus
			{
				get
				{
					const string __id = "PrePlus.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Precision']"
			[Register("Precision")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Precision
			{
				get
				{
					const string __id = "Precision.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PrecisionGoal']"
			[Register("PrecisionGoal")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PrecisionGoal
			{
				get
				{
					const string __id = "PrecisionGoal.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Prepend']"
			[Register("Prepend")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Prepend
			{
				get
				{
					const string __id = "Prepend.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PrependTo']"
			[Register("PrependTo")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PrependTo
			{
				get
				{
					const string __id = "PrependTo.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Prime']"
			[Register("Prime")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Prime
			{
				get
				{
					const string __id = "Prime.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PrimeOmega']"
			[Register("PrimeOmega")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PrimeOmega
			{
				get
				{
					const string __id = "PrimeOmega.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PrimePi']"
			[Register("PrimePi")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PrimePi
			{
				get
				{
					const string __id = "PrimePi.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PrimePowerQ']"
			[Register("PrimePowerQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PrimePowerQ
			{
				get
				{
					const string __id = "PrimePowerQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PrimeQ']"
			[Register("PrimeQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PrimeQ
			{
				get
				{
					const string __id = "PrimeQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Primes']"
			[Register("Primes")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Primes
			{
				get
				{
					const string __id = "Primes.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PrimitiveRoot']"
			[Register("PrimitiveRoot")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PrimitiveRoot
			{
				get
				{
					const string __id = "PrimitiveRoot.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PrimitiveRootList']"
			[Register("PrimitiveRootList")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PrimitiveRootList
			{
				get
				{
					const string __id = "PrimitiveRootList.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Print']"
			[Register("Print")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Print
			{
				get
				{
					const string __id = "Print.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Probability']"
			[Register("Probability")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Probability
			{
				get
				{
					const string __id = "Probability.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Product']"
			[Register("Product")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Product
			{
				get
				{
					const string __id = "Product.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ProductLog']"
			[Register("ProductLog")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ProductLog
			{
				get
				{
					const string __id = "ProductLog.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Projection']"
			[Register("Projection")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Projection
			{
				get
				{
					const string __id = "Projection.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='PseudoInverse']"
			[Register("PseudoInverse")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol PseudoInverse
			{
				get
				{
					const string __id = "PseudoInverse.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Put']"
			[Register("Put")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Put
			{
				get
				{
					const string __id = "Put.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='QRDecomposition']"
			[Register("QRDecomposition")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol QRDecomposition
			{
				get
				{
					const string __id = "QRDecomposition.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Quantile']"
			[Register("Quantile")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Quantile
			{
				get
				{
					const string __id = "Quantile.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Quantity']"
			[Register("Quantity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Quantity
			{
				get
				{
					const string __id = "Quantity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='QuantityDistribution']"
			[Register("QuantityDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol QuantityDistribution
			{
				get
				{
					const string __id = "QuantityDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='QuantityMagnitude']"
			[Register("QuantityMagnitude")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol QuantityMagnitude
			{
				get
				{
					const string __id = "QuantityMagnitude.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='QuantityQ']"
			[Register("QuantityQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol QuantityQ
			{
				get
				{
					const string __id = "QuantityQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Quiet']"
			[Register("Quiet")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Quiet
			{
				get
				{
					const string __id = "Quiet.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Quit']"
			[Register("Quit")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Quit
			{
				get
				{
					const string __id = "Quit.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Quotient']"
			[Register("Quotient")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Quotient
			{
				get
				{
					const string __id = "Quotient.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='QuotientRemainder']"
			[Register("QuotientRemainder")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol QuotientRemainder
			{
				get
				{
					const string __id = "QuotientRemainder.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RandomChoice']"
			[Register("RandomChoice")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RandomChoice
			{
				get
				{
					const string __id = "RandomChoice.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RandomInteger']"
			[Register("RandomInteger")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RandomInteger
			{
				get
				{
					const string __id = "RandomInteger.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RandomReal']"
			[Register("RandomReal")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RandomReal
			{
				get
				{
					const string __id = "RandomReal.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RandomSample']"
			[Register("RandomSample")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RandomSample
			{
				get
				{
					const string __id = "RandomSample.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RandomVariate']"
			[Register("RandomVariate")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RandomVariate
			{
				get
				{
					const string __id = "RandomVariate.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Range']"
			[Register("Range")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Range
			{
				get
				{
					const string __id = "Range.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Rational']"
			[Register("Rational")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Rational
			{
				get
				{
					const string __id = "Rational.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Rationalize']"
			[Register("Rationalize")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Rationalize
			{
				get
				{
					const string __id = "Rationalize.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Rationals']"
			[Register("Rationals")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Rationals
			{
				get
				{
					const string __id = "Rationals.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Re']"
			[Register("Re")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Re
			{
				get
				{
					const string __id = "Re.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Real']"
			[Register("Real")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Real
			{
				get
				{
					const string __id = "Real.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RealNumberQ']"
			[Register("RealNumberQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RealNumberQ
			{
				get
				{
					const string __id = "RealNumberQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Reals']"
			[Register("Reals")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Reals
			{
				get
				{
					const string __id = "Reals.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Reap']"
			[Register("Reap")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Reap
			{
				get
				{
					const string __id = "Reap.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Rectangle']"
			[Register("Rectangle")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Rectangle
			{
				get
				{
					const string __id = "Rectangle.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Reduce']"
			[Register("Reduce")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Reduce
			{
				get
				{
					const string __id = "Reduce.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Refine']"
			[Register("Refine")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Refine
			{
				get
				{
					const string __id = "Refine.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Repeated']"
			[Register("Repeated")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Repeated
			{
				get
				{
					const string __id = "Repeated.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RepeatedNull']"
			[Register("RepeatedNull")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RepeatedNull
			{
				get
				{
					const string __id = "RepeatedNull.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Replace']"
			[Register("Replace")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Replace
			{
				get
				{
					const string __id = "Replace.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ReplaceAll']"
			[Register("ReplaceAll")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ReplaceAll
			{
				get
				{
					const string __id = "ReplaceAll.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ReplaceList']"
			[Register("ReplaceList")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ReplaceList
			{
				get
				{
					const string __id = "ReplaceList.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ReplacePart']"
			[Register("ReplacePart")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ReplacePart
			{
				get
				{
					const string __id = "ReplacePart.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ReplaceRepeated']"
			[Register("ReplaceRepeated")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ReplaceRepeated
			{
				get
				{
					const string __id = "ReplaceRepeated.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Rescale']"
			[Register("Rescale")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Rescale
			{
				get
				{
					const string __id = "Rescale.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Rest']"
			[Register("Rest")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Rest
			{
				get
				{
					const string __id = "Rest.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Resultant']"
			[Register("Resultant")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Resultant
			{
				get
				{
					const string __id = "Resultant.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Return']"
			[Register("Return")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Return
			{
				get
				{
					const string __id = "Return.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Reverse']"
			[Register("Reverse")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Reverse
			{
				get
				{
					const string __id = "Reverse.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Riffle']"
			[Register("Riffle")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Riffle
			{
				get
				{
					const string __id = "Riffle.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RogersTanimotoDissimilarity']"
			[Register("RogersTanimotoDissimilarity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RogersTanimotoDissimilarity
			{
				get
				{
					const string __id = "RogersTanimotoDissimilarity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Root']"
			[Register("Root")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Root
			{
				get
				{
					const string __id = "Root.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RootIntervals']"
			[Register("RootIntervals")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RootIntervals
			{
				get
				{
					const string __id = "RootIntervals.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RootOf']"
			[Register("RootOf")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RootOf
			{
				get
				{
					const string __id = "RootOf.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Roots']"
			[Register("Roots")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Roots
			{
				get
				{
					const string __id = "Roots.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RotateLeft']"
			[Register("RotateLeft")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RotateLeft
			{
				get
				{
					const string __id = "RotateLeft.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RotateRight']"
			[Register("RotateRight")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RotateRight
			{
				get
				{
					const string __id = "RotateRight.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Round']"
			[Register("Round")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Round
			{
				get
				{
					const string __id = "Round.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RowReduce']"
			[Register("RowReduce")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RowReduce
			{
				get
				{
					const string __id = "RowReduce.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Rule']"
			[Register("Rule")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Rule
			{
				get
				{
					const string __id = "Rule.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RuleDelayed']"
			[Register("RuleDelayed")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RuleDelayed
			{
				get
				{
					const string __id = "RuleDelayed.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='RussellRaoDissimilarity']"
			[Register("RussellRaoDissimilarity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol RussellRaoDissimilarity
			{
				get
				{
					const string __id = "RussellRaoDissimilarity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SameQ']"
			[Register("SameQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SameQ
			{
				get
				{
					const string __id = "SameQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SatisfiabilityCount']"
			[Register("SatisfiabilityCount")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SatisfiabilityCount
			{
				get
				{
					const string __id = "SatisfiabilityCount.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SatisfiabilityInstances']"
			[Register("SatisfiabilityInstances")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SatisfiabilityInstances
			{
				get
				{
					const string __id = "SatisfiabilityInstances.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SatisfiableQ']"
			[Register("SatisfiableQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SatisfiableQ
			{
				get
				{
					const string __id = "SatisfiableQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Scan']"
			[Register("Scan")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Scan
			{
				get
				{
					const string __id = "Scan.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sec']"
			[Register("Sec")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sec
			{
				get
				{
					const string __id = "Sec.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sech']"
			[Register("Sech")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sech
			{
				get
				{
					const string __id = "Sech.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Second']"
			[Register("Second")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Second
			{
				get
				{
					const string __id = "Second.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Select']"
			[Register("Select")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Select
			{
				get
				{
					const string __id = "Select.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sequence']"
			[Register("Sequence")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sequence
			{
				get
				{
					const string __id = "Sequence.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Series']"
			[Register("Series")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Series
			{
				get
				{
					const string __id = "Series.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SeriesCoefficient']"
			[Register("SeriesCoefficient")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SeriesCoefficient
			{
				get
				{
					const string __id = "SeriesCoefficient.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SeriesData']"
			[Register("SeriesData")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SeriesData
			{
				get
				{
					const string __id = "SeriesData.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Set']"
			[Register("Set")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Set
			{
				get
				{
					const string __id = "Set.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SetAttributes']"
			[Register("SetAttributes")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SetAttributes
			{
				get
				{
					const string __id = "SetAttributes.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SetDelayed']"
			[Register("SetDelayed")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SetDelayed
			{
				get
				{
					const string __id = "SetDelayed.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Share']"
			[Register("Share")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Share
			{
				get
				{
					const string __id = "Share.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Show']"
			[Register("Show")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Show
			{
				get
				{
					const string __id = "Show.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sign']"
			[Register("Sign")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sign
			{
				get
				{
					const string __id = "Sign.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SignCmp']"
			[Register("SignCmp")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SignCmp
			{
				get
				{
					const string __id = "SignCmp.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Simplify']"
			[Register("Simplify")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Simplify
			{
				get
				{
					const string __id = "Simplify.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sin']"
			[Register("Sin")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sin
			{
				get
				{
					const string __id = "Sin.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SinIntegral']"
			[Register("SinIntegral")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SinIntegral
			{
				get
				{
					const string __id = "SinIntegral.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sinc']"
			[Register("Sinc")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sinc
			{
				get
				{
					const string __id = "Sinc.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SingularValueDecomposition']"
			[Register("SingularValueDecomposition")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SingularValueDecomposition
			{
				get
				{
					const string __id = "SingularValueDecomposition.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sinh']"
			[Register("Sinh")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sinh
			{
				get
				{
					const string __id = "Sinh.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SinhIntegral']"
			[Register("SinhIntegral")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SinhIntegral
			{
				get
				{
					const string __id = "SinhIntegral.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Skewness']"
			[Register("Skewness")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Skewness
			{
				get
				{
					const string __id = "Skewness.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Slot']"
			[Register("Slot")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Slot
			{
				get
				{
					const string __id = "Slot.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SlotSequence']"
			[Register("SlotSequence")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SlotSequence
			{
				get
				{
					const string __id = "SlotSequence.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SokalSneathDissimilarity']"
			[Register("SokalSneathDissimilarity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SokalSneathDissimilarity
			{
				get
				{
					const string __id = "SokalSneathDissimilarity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Solve']"
			[Register("Solve")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Solve
			{
				get
				{
					const string __id = "Solve.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sort']"
			[Register("Sort")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sort
			{
				get
				{
					const string __id = "Sort.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sow']"
			[Register("Sow")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sow
			{
				get
				{
					const string __id = "Sow.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Span']"
			[Register("Span")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Span
			{
				get
				{
					const string __id = "Span.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Split']"
			[Register("Split")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Split
			{
				get
				{
					const string __id = "Split.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SplitBy']"
			[Register("SplitBy")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SplitBy
			{
				get
				{
					const string __id = "SplitBy.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sqrt']"
			[Register("Sqrt")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sqrt
			{
				get
				{
					const string __id = "Sqrt.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SquareFreeQ']"
			[Register("SquareFreeQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SquareFreeQ
			{
				get
				{
					const string __id = "SquareFreeQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SquareMatrixQ']"
			[Register("SquareMatrixQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SquareMatrixQ
			{
				get
				{
					const string __id = "SquareMatrixQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SquaredEuclideanDistance']"
			[Register("SquaredEuclideanDistance")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SquaredEuclideanDistance
			{
				get
				{
					const string __id = "SquaredEuclideanDistance.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StandardDeviation']"
			[Register("StandardDeviation")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StandardDeviation
			{
				get
				{
					const string __id = "StandardDeviation.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StandardForm']"
			[Register("StandardForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StandardForm
			{
				get
				{
					const string __id = "StandardForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Standardize']"
			[Register("Standardize")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Standardize
			{
				get
				{
					const string __id = "Standardize.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StieltjesGamma']"
			[Register("StieltjesGamma")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StieltjesGamma
			{
				get
				{
					const string __id = "StieltjesGamma.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StirlingS1']"
			[Register("StirlingS1")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StirlingS1
			{
				get
				{
					const string __id = "StirlingS1.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StirlingS2']"
			[Register("StirlingS2")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StirlingS2
			{
				get
				{
					const string __id = "StirlingS2.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='String']"
			[Register("String")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol String
			{
				get
				{
					const string __id = "String.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StringDrop']"
			[Register("StringDrop")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StringDrop
			{
				get
				{
					const string __id = "StringDrop.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StringJoin']"
			[Register("StringJoin")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StringJoin
			{
				get
				{
					const string __id = "StringJoin.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StringLength']"
			[Register("StringLength")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StringLength
			{
				get
				{
					const string __id = "StringLength.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StringTake']"
			[Register("StringTake")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StringTake
			{
				get
				{
					const string __id = "StringTake.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StruveH']"
			[Register("StruveH")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StruveH
			{
				get
				{
					const string __id = "StruveH.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StruveL']"
			[Register("StruveL")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StruveL
			{
				get
				{
					const string __id = "StruveL.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='StudentTDistribution']"
			[Register("StudentTDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol StudentTDistribution
			{
				get
				{
					const string __id = "StudentTDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Subdivide']"
			[Register("Subdivide")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Subdivide
			{
				get
				{
					const string __id = "Subdivide.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Subfactorial']"
			[Register("Subfactorial")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Subfactorial
			{
				get
				{
					const string __id = "Subfactorial.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Subscript']"
			[Register("Subscript")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Subscript
			{
				get
				{
					const string __id = "Subscript.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Subsets']"
			[Register("Subsets")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Subsets
			{
				get
				{
					const string __id = "Subsets.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Subsuperscript']"
			[Register("Subsuperscript")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Subsuperscript
			{
				get
				{
					const string __id = "Subsuperscript.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Subtract']"
			[Register("Subtract")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Subtract
			{
				get
				{
					const string __id = "Subtract.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SubtractFrom']"
			[Register("SubtractFrom")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SubtractFrom
			{
				get
				{
					const string __id = "SubtractFrom.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Sum']"
			[Register("Sum")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Sum
			{
				get
				{
					const string __id = "Sum.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Superscript']"
			[Register("Superscript")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Superscript
			{
				get
				{
					const string __id = "Superscript.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Surd']"
			[Register("Surd")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Surd
			{
				get
				{
					const string __id = "Surd.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SurfaceGraphics']"
			[Register("SurfaceGraphics")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SurfaceGraphics
			{
				get
				{
					const string __id = "SurfaceGraphics.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Switch']"
			[Register("Switch")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Switch
			{
				get
				{
					const string __id = "Switch.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Symbol']"
			[Register("Symbol")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Symbol
			{
				get
				{
					const string __id = "Symbol.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SymbolName']"
			[Register("SymbolName")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SymbolName
			{
				get
				{
					const string __id = "SymbolName.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SymbolQ']"
			[Register("SymbolQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SymbolQ
			{
				get
				{
					const string __id = "SymbolQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Symmetric']"
			[Register("Symmetric")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Symmetric
			{
				get
				{
					const string __id = "Symmetric.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SymmetricMatrixQ']"
			[Register("SymmetricMatrixQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SymmetricMatrixQ
			{
				get
				{
					const string __id = "SymmetricMatrixQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SyntaxLength']"
			[Register("SyntaxLength")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SyntaxLength
			{
				get
				{
					const string __id = "SyntaxLength.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='SyntaxQ']"
			[Register("SyntaxQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol SyntaxQ
			{
				get
				{
					const string __id = "SyntaxQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Table']"
			[Register("Table")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Table
			{
				get
				{
					const string __id = "Table.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TableForm']"
			[Register("TableForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TableForm
			{
				get
				{
					const string __id = "TableForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Take']"
			[Register("Take")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Take
			{
				get
				{
					const string __id = "Take.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Tally']"
			[Register("Tally")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Tally
			{
				get
				{
					const string __id = "Tally.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Tan']"
			[Register("Tan")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Tan
			{
				get
				{
					const string __id = "Tan.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Tanh']"
			[Register("Tanh")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Tanh
			{
				get
				{
					const string __id = "Tanh.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TautologyQ']"
			[Register("TautologyQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TautologyQ
			{
				get
				{
					const string __id = "TautologyQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Taylor']"
			[Register("Taylor")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Taylor
			{
				get
				{
					const string __id = "Taylor.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TeXForm']"
			[Register("TeXForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TeXForm
			{
				get
				{
					const string __id = "TeXForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TensorDimensions']"
			[Register("TensorDimensions")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TensorDimensions
			{
				get
				{
					const string __id = "TensorDimensions.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TensorProduct']"
			[Register("TensorProduct")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TensorProduct
			{
				get
				{
					const string __id = "TensorProduct.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TensorRank']"
			[Register("TensorRank")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TensorRank
			{
				get
				{
					const string __id = "TensorRank.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TensorSymmetry']"
			[Register("TensorSymmetry")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TensorSymmetry
			{
				get
				{
					const string __id = "TensorSymmetry.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Thread']"
			[Register("Thread")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Thread
			{
				get
				{
					const string __id = "Thread.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Through']"
			[Register("Through")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Through
			{
				get
				{
					const string __id = "Through.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Throw']"
			[Register("Throw")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Throw
			{
				get
				{
					const string __id = "Throw.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TimeConstrained']"
			[Register("TimeConstrained")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TimeConstrained
			{
				get
				{
					const string __id = "TimeConstrained.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TimeValue']"
			[Register("TimeValue")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TimeValue
			{
				get
				{
					const string __id = "TimeValue.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Times']"
			[Register("Times")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Times
			{
				get
				{
					const string __id = "Times.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TimesBy']"
			[Register("TimesBy")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TimesBy
			{
				get
				{
					const string __id = "TimesBy.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Timing']"
			[Register("Timing")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Timing
			{
				get
				{
					const string __id = "Timing.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ToCharacterCode']"
			[Register("ToCharacterCode")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ToCharacterCode
			{
				get
				{
					const string __id = "ToCharacterCode.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ToPolarCoordinates']"
			[Register("ToPolarCoordinates")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ToPolarCoordinates
			{
				get
				{
					const string __id = "ToPolarCoordinates.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ToRadicals']"
			[Register("ToRadicals")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ToRadicals
			{
				get
				{
					const string __id = "ToRadicals.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ToString']"
			[Register("ToString")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ToString
			{
				get
				{
					const string __id = "ToString.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ToUnicode']"
			[Register("ToUnicode")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ToUnicode
			{
				get
				{
					const string __id = "ToUnicode.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ToeplitzMatrix']"
			[Register("ToeplitzMatrix")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ToeplitzMatrix
			{
				get
				{
					const string __id = "ToeplitzMatrix.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Together']"
			[Register("Together")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Together
			{
				get
				{
					const string __id = "Together.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TooLarge']"
			[Register("TooLarge")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TooLarge
			{
				get
				{
					const string __id = "TooLarge.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Total']"
			[Register("Total")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Total
			{
				get
				{
					const string __id = "Total.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Tr']"
			[Register("Tr")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Tr
			{
				get
				{
					const string __id = "Tr.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Trace']"
			[Register("Trace")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Trace
			{
				get
				{
					const string __id = "Trace.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TraditionalForm']"
			[Register("TraditionalForm")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TraditionalForm
			{
				get
				{
					const string __id = "TraditionalForm.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Transpose']"
			[Register("Transpose")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Transpose
			{
				get
				{
					const string __id = "Transpose.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Trig']"
			[Register("Trig")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Trig
			{
				get
				{
					const string __id = "Trig.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TrigExpand']"
			[Register("TrigExpand")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TrigExpand
			{
				get
				{
					const string __id = "TrigExpand.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TrigReduce']"
			[Register("TrigReduce")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TrigReduce
			{
				get
				{
					const string __id = "TrigReduce.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TrigToExp']"
			[Register("TrigToExp")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TrigToExp
			{
				get
				{
					const string __id = "TrigToExp.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='True']"
			[Register("True")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol True
			{
				get
				{
					const string __id = "True.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='TrueQ']"
			[Register("TrueQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol TrueQ
			{
				get
				{
					const string __id = "TrueQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Tuples']"
			[Register("Tuples")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Tuples
			{
				get
				{
					const string __id = "Tuples.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Undefined']"
			[Register("Undefined")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Undefined
			{
				get
				{
					const string __id = "Undefined.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Unequal']"
			[Register("Unequal")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Unequal
			{
				get
				{
					const string __id = "Unequal.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Unevaluated']"
			[Register("Unevaluated")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Unevaluated
			{
				get
				{
					const string __id = "Unevaluated.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='UniformDistribution']"
			[Register("UniformDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol UniformDistribution
			{
				get
				{
					const string __id = "UniformDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Union']"
			[Register("Union")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Union
			{
				get
				{
					const string __id = "Union.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Unique']"
			[Register("Unique")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Unique
			{
				get
				{
					const string __id = "Unique.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='UnitConvert']"
			[Register("UnitConvert")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol UnitConvert
			{
				get
				{
					const string __id = "UnitConvert.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='UnitStep']"
			[Register("UnitStep")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol UnitStep
			{
				get
				{
					const string __id = "UnitStep.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='UnitVector']"
			[Register("UnitVector")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol UnitVector
			{
				get
				{
					const string __id = "UnitVector.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='UnitaryMatrixQ']"
			[Register("UnitaryMatrixQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol UnitaryMatrixQ
			{
				get
				{
					const string __id = "UnitaryMatrixQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Unitize']"
			[Register("Unitize")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Unitize
			{
				get
				{
					const string __id = "Unitize.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Unknown']"
			[Register("Unknown")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Unknown
			{
				get
				{
					const string __id = "Unknown.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='UnsameQ']"
			[Register("UnsameQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol UnsameQ
			{
				get
				{
					const string __id = "UnsameQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Unset']"
			[Register("Unset")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Unset
			{
				get
				{
					const string __id = "Unset.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='UpSet']"
			[Register("UpSet")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol UpSet
			{
				get
				{
					const string __id = "UpSet.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='UpSetDelayed']"
			[Register("UpSetDelayed")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol UpSetDelayed
			{
				get
				{
					const string __id = "UpSetDelayed.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='UpperCaseQ']"
			[Register("UpperCaseQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol UpperCaseQ
			{
				get
				{
					const string __id = "UpperCaseQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='UpperTriangularize']"
			[Register("UpperTriangularize")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol UpperTriangularize
			{
				get
				{
					const string __id = "UpperTriangularize.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ValueQ']"
			[Register("ValueQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ValueQ
			{
				get
				{
					const string __id = "ValueQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='VandermondeMatrix']"
			[Register("VandermondeMatrix")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol VandermondeMatrix
			{
				get
				{
					const string __id = "VandermondeMatrix.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Variable']"
			[Register("Variable")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Variable
			{
				get
				{
					const string __id = "Variable.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Variables']"
			[Register("Variables")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Variables
			{
				get
				{
					const string __id = "Variables.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Variance']"
			[Register("Variance")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Variance
			{
				get
				{
					const string __id = "Variance.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='VectorAngle']"
			[Register("VectorAngle")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol VectorAngle
			{
				get
				{
					const string __id = "VectorAngle.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='VectorQ']"
			[Register("VectorQ")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol VectorQ
			{
				get
				{
					const string __id = "VectorQ.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='WeibullDistribution']"
			[Register("WeibullDistribution")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol WeibullDistribution
			{
				get
				{
					const string __id = "WeibullDistribution.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Which']"
			[Register("Which")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Which
			{
				get
				{
					const string __id = "Which.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='While']"
			[Register("While")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol While
			{
				get
				{
					const string __id = "While.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='White']"
			[Register("White")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol White
			{
				get
				{
					const string __id = "White.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='With']"
			[Register("With")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol With
			{
				get
				{
					const string __id = "With.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Xor']"
			[Register("Xor")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Xor
			{
				get
				{
					const string __id = "Xor.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='YuleDissimilarity']"
			[Register("YuleDissimilarity")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol YuleDissimilarity
			{
				get
				{
					const string __id = "YuleDissimilarity.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='ZeroSymmetric']"
			[Register("ZeroSymmetric")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol ZeroSymmetric
			{
				get
				{
					const string __id = "ZeroSymmetric.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.matheclipse.core.expression']/class[@name='F']/field[@name='Zeta']"
			[Register("Zeta")]
			public static global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol Zeta
			{
				get
				{
					const string __id = "Zeta.Lorg/matheclipse/core/interfaces/IBuiltInSymbol;";

					var __v = _members.StaticFields.GetObjectValue(__id);
					return global::Java.Lang.Object.GetObject<global::Org.Matheclipse.Core.Interfaces.IBuiltInSymbol>(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
		}
	}
}
