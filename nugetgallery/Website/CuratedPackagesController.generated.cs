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
namespace NuGetGallery {
    public partial class CuratedPackagesController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CuratedPackagesController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CuratedPackagesController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult GetCreateCuratedPackageForm() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.GetCreateCuratedPackageForm);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeleteCuratedPackage() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeleteCuratedPackage);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult PatchCuratedPackage() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.PatchCuratedPackage);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult PostCuratedPackages() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.PostCuratedPackages);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CuratedPackagesController Actions { get { return MVC.CuratedPackages; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "CuratedPackages";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string GetCreateCuratedPackageForm = "CreateCuratedPackageForm";
            public readonly string DeleteCuratedPackage = "CuratedPackage";
            public readonly string PatchCuratedPackage = "CuratedPackage";
            public readonly string PostCuratedPackages = "CuratedPackages";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string CreateCuratedPackageForm = "~/Views/CuratedPackages/CreateCuratedPackageForm.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_CuratedPackagesController: NuGetGallery.CuratedPackagesController {
        public T4MVC_CuratedPackagesController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult GetCreateCuratedPackageForm(string curatedFeedName) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.GetCreateCuratedPackageForm);
            callInfo.RouteValueDictionary.Add("curatedFeedName", curatedFeedName);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeleteCuratedPackage(string curatedFeedName, string curatedPackageId) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeleteCuratedPackage);
            callInfo.RouteValueDictionary.Add("curatedFeedName", curatedFeedName);
            callInfo.RouteValueDictionary.Add("curatedPackageId", curatedPackageId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult PatchCuratedPackage(string curatedFeedName, string curatedPackageId, NuGetGallery.ModifyCuratedPackageRequest request) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.PatchCuratedPackage);
            callInfo.RouteValueDictionary.Add("curatedFeedName", curatedFeedName);
            callInfo.RouteValueDictionary.Add("curatedPackageId", curatedPackageId);
            callInfo.RouteValueDictionary.Add("request", request);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult PostCuratedPackages(string curatedFeedName, NuGetGallery.CreateCuratedPackageRequest request) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.PostCuratedPackages);
            callInfo.RouteValueDictionary.Add("curatedFeedName", curatedFeedName);
            callInfo.RouteValueDictionary.Add("request", request);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
