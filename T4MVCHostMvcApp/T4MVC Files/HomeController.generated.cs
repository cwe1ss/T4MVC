// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace T4MVCHostMvcApp.Controllers {
    public partial class HomeController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HomeController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Blah() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Blah);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ActionWithArrayParam() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.ActionWithArrayParam);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ActionWithSomeOptionalParams() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.ActionWithSomeOptionalParams);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ActionWithParamUsingAtSyntax() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.ActionWithParamUsingAtSyntax);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ActionThatRequiresHttps() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.ActionThatRequiresHttps, "https");
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult OverloadedActionWithDifferentParams() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.OverloadedActionWithDifferentParams);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController Actions { get { return MVC.Home; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Home";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Home";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Index = "Index";
            public readonly string About = firstConst + " " + secondConst;
            public readonly string Blah = "New-Name for Blah";
            public readonly string SomeViewResultAction = "SomeViewResultAction";
            public readonly string SomeJsonResultAction = "SomeJsonResultAction";
            public readonly string SomeFileContentResultAction = "SomeFileContentResultAction";
            public readonly string SomeFileStreamResultAction = "SomeFileStreamResultAction";
            public readonly string SomeFileResultAction = "SomeFileResultAction";
            public readonly string SomeCustomResultAction = "SomeCustomResultAction";
            public readonly string ActionWithArrayParam = "ActionWithArrayParam";
            public readonly string ActionWithAllOptionalParams = "ActionWithAllOptionalParams";
            public readonly string ActionWithSomeOptionalParams = "ActionWithSomeOptionalParams";
            public readonly string ActionWithParamUsingAtSyntax = "ActionWithParamUsingAtSyntax";
            public readonly string ActionThatUsesActionNameConstantInAttribute = "ActionThatUsesActionNameConstantInAttribute";
            public readonly string ActionThatRequiresHttps = "ActionThatRequiresHttps";
            public readonly string OverloadedActionWithDifferentParams = "OverloadedActionWithDifferentParams";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string Index = "Index";
            public const string About = firstConst + " " + secondConst;
            public const string Blah = "New-Name for Blah";
            public const string SomeViewResultAction = "SomeViewResultAction";
            public const string SomeJsonResultAction = "SomeJsonResultAction";
            public const string SomeFileContentResultAction = "SomeFileContentResultAction";
            public const string SomeFileStreamResultAction = "SomeFileStreamResultAction";
            public const string SomeFileResultAction = "SomeFileResultAction";
            public const string SomeCustomResultAction = "SomeCustomResultAction";
            public const string ActionWithArrayParam = "ActionWithArrayParam";
            public const string ActionWithAllOptionalParams = "ActionWithAllOptionalParams";
            public const string ActionWithSomeOptionalParams = "ActionWithSomeOptionalParams";
            public const string ActionWithParamUsingAtSyntax = "ActionWithParamUsingAtSyntax";
            public const string ActionThatUsesActionNameConstantInAttribute = "ActionThatUsesActionNameConstantInAttribute";
            public const string ActionThatRequiresHttps = "ActionThatRequiresHttps";
            public const string OverloadedActionWithDifferentParams = "OverloadedActionWithDifferentParams";
        }


        static readonly ActionParamsClass_Blah s_params_Blah = new ActionParamsClass_Blah();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Blah BlahParams { get { return s_params_Blah; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Blah {
            public readonly string name = "name";
            public readonly string age = "age";
        }
        static readonly ActionParamsClass_ActionWithArrayParam s_params_ActionWithArrayParam = new ActionParamsClass_ActionWithArrayParam();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionWithArrayParam ActionWithArrayParamParams { get { return s_params_ActionWithArrayParam; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionWithArrayParam {
            public readonly string someStrings = "someStrings";
        }
        static readonly ActionParamsClass_ActionWithAllOptionalParams s_params_ActionWithAllOptionalParams = new ActionParamsClass_ActionWithAllOptionalParams();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionWithAllOptionalParams ActionWithAllOptionalParamsParams { get { return s_params_ActionWithAllOptionalParams; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionWithAllOptionalParams {
            public readonly string someString = "someString";
            public readonly string n = "n";
        }
        static readonly ActionParamsClass_ActionWithSomeOptionalParams s_params_ActionWithSomeOptionalParams = new ActionParamsClass_ActionWithSomeOptionalParams();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionWithSomeOptionalParams ActionWithSomeOptionalParamsParams { get { return s_params_ActionWithSomeOptionalParams; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionWithSomeOptionalParams {
            public readonly string someString = "someString";
            public readonly string n = "n";
        }
        static readonly ActionParamsClass_ActionWithParamUsingAtSyntax s_params_ActionWithParamUsingAtSyntax = new ActionParamsClass_ActionWithParamUsingAtSyntax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionWithParamUsingAtSyntax ActionWithParamUsingAtSyntaxParams { get { return s_params_ActionWithParamUsingAtSyntax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionWithParamUsingAtSyntax {
            public readonly string @event = "event";
        }
        static readonly ActionParamsClass_ActionThatRequiresHttps s_params_ActionThatRequiresHttps = new ActionParamsClass_ActionThatRequiresHttps();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionThatRequiresHttps ActionThatRequiresHttpsParams { get { return s_params_ActionThatRequiresHttps; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionThatRequiresHttps {
            public readonly string someString = "someString";
        }
        static readonly ActionParamsClass_OverloadedActionWithDifferentParams s_params_OverloadedActionWithDifferentParams = new ActionParamsClass_OverloadedActionWithDifferentParams();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_OverloadedActionWithDifferentParams OverloadedActionWithDifferentParamsParams { get { return s_params_OverloadedActionWithDifferentParams; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_OverloadedActionWithDifferentParams {
            public readonly string someString = "someString";
        }
        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string _7_Some_Home_View_Hello = "~/Views/Home/7 Some Home.View-Hello.txt";
            public readonly string About = "~/Views/Home/About.aspx";
            public readonly string DuplicateControl = "~/Views/Home/DuplicateControl.ascx";
            public readonly string Index = "~/Views/Home/Index.aspx";
            public readonly string Qqq = "~/Views/Home/Qqq.txt";
            public readonly string QqQ = "~/Views/Home/QqQ.txt2";
            public readonly string Qqq_txt3 = "~/Views/Home/Qqq.txt3";
            static readonly _default s_default = new _default();
            public _default @default { get { return s_default; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _default{
            }
            static readonly _DisplayTemplates s_DisplayTemplates = new _DisplayTemplates();
            public _DisplayTemplates DisplayTemplates { get { return s_DisplayTemplates; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _DisplayTemplates{
                public readonly string SomeDisplayTemplate = "SomeDisplayTemplate";
            }
            static readonly _EditorTemplates s_EditorTemplates = new _EditorTemplates();
            public _EditorTemplates EditorTemplates { get { return s_EditorTemplates; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _EditorTemplates{
                public readonly string SomeEditorTemplate = "SomeEditorTemplate";
            }
            static readonly _SomeName s_SomeName = new _SomeName();
            public _SomeName SomeName { get { return s_SomeName; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _SomeName{
                static readonly _SomeName_ s_SomeName = new _SomeName_();
                public _SomeName_ SomeName { get { return s_SomeName; } }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public partial class _SomeName_{
                    public readonly string SomeName = "~/Views/Home/SomeName/SomeName/SomeName.txt";
                }
            }
            static readonly _Sub_Home s_Sub_Home = new _Sub_Home();
            public _Sub_Home Sub_Home { get { return s_Sub_Home; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _Sub_Home{
                public readonly string Qqq = "~/Views/Home/Sub Home/Qqq.txt";
                public readonly string @string = "~/Views/Home/Sub Home/string.txt";
                public readonly string T4View = "~/Views/Home/Sub Home/T4View.tt";
                static readonly _Nested_Sub s_Nested_Sub = new _Nested_Sub();
                public _Nested_Sub Nested_Sub { get { return s_Nested_Sub; } }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public partial class _Nested_Sub{
                    public readonly string _99_Super_Nested_View = "~/Views/Home/Sub Home/Nested-Sub/99 Super~Nested-View.txt";
                }
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_HomeController: T4MVCHostMvcApp.Controllers.HomeController {
        public T4MVC_HomeController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Index);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult About() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.About);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Blah(string name, int age) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Blah);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "name", name);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "age", age);
            return callInfo;
        }

        public override System.Web.Mvc.ViewResult SomeViewResultAction() {
            var callInfo = new T4MVC_ViewResult(Area, Name, ActionNames.SomeViewResultAction);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult SomeJsonResultAction() {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.SomeJsonResultAction);
            return callInfo;
        }

        public override System.Web.Mvc.FileContentResult SomeFileContentResultAction() {
            var callInfo = new T4MVC_FileContentResult(Area, Name, ActionNames.SomeFileContentResultAction);
            return callInfo;
        }

        public override System.Web.Mvc.FileStreamResult SomeFileStreamResultAction() {
            var callInfo = new T4MVC_FileStreamResult(Area, Name, ActionNames.SomeFileStreamResultAction);
            return callInfo;
        }

        public override System.Web.Mvc.FileResult SomeFileResultAction() {
            var callInfo = new T4MVC_FileResult(Area, Name, ActionNames.SomeFileResultAction);
            return callInfo;
        }

        public override T4MVCHostMvcApp.Misc.MyCustomResult SomeCustomResultAction() {
            var callInfo = new T4MVC_MyCustomResult(Area, Name, ActionNames.SomeCustomResultAction);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ActionWithArrayParam(string[] someStrings) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ActionWithArrayParam);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someStrings", someStrings);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ActionWithAllOptionalParams(string someString, int n) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ActionWithAllOptionalParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someString", someString);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "n", n);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ActionWithSomeOptionalParams(string someString, int n) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ActionWithSomeOptionalParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someString", someString);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "n", n);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ActionWithParamUsingAtSyntax(int @event) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ActionWithParamUsingAtSyntax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "event", @event);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ActionThatUsesActionNameConstantInAttribute() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ActionThatUsesActionNameConstantInAttribute);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ActionThatRequiresHttps(string someString) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ActionThatRequiresHttps, "https");
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someString", someString);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult OverloadedActionWithDifferentParams(string someString) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.OverloadedActionWithDifferentParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someString", someString);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult OverloadedActionWithDifferentParams(int someNumber) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.OverloadedActionWithDifferentParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someNumber", someNumber);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
