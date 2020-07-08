using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;

namespace SecuritySetState.Module.Win.Controllers {
    public class SetStateController : ViewController{
       public SetStateController() {
            TargetViewId = "PermissionPolicyRoleBase_TypePermissions_ListView;PermissionPolicyRoleBase_NavigationPermissions_ListView";
        }
        private NewObjectViewController controller;
        protected override void OnActivated() {
            base.OnActivated();
            controller = Frame.GetController<NewObjectViewController>();
            if(controller != null) {
                controller.ObjectCreated += controller_ObjectCreated;
            }
        }
        void controller_ObjectCreated(object sender, ObjectCreatedEventArgs e) {
            PermissionPolicyTypePermissionObject typePermission = e.CreatedObject as PermissionPolicyTypePermissionObject;
            if(typePermission != null) {
                typePermission.ReadState = SecurityPermissionState.Allow;
                typePermission.WriteState = SecurityPermissionState.Allow;
            }
            PermissionPolicyNavigationPermissionObject navigationPermisson = e.CreatedObject as PermissionPolicyNavigationPermissionObject;
            if(navigationPermisson != null) {
                navigationPermisson.NavigateState = SecurityPermissionState.Allow;
            }
        }
        protected override void OnDeactivated() {
            if(controller != null) {
                controller.ObjectCreated -= controller_ObjectCreated;
            }
            base.OnDeactivated();
        }
    }
}
