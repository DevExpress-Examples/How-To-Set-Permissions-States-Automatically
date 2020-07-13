using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;

namespace SecuritySetState.Module.Controllers {
    public class SetStateController : ViewController {
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
                SecurityPermissionState defaultState = SecurityPermissionState.Allow;
                if(typePermission.Role.PermissionPolicy == SecurityPermissionPolicy.AllowAllByDefault) {
                    defaultState = SecurityPermissionState.Deny;
                }
                typePermission.ReadState = defaultState;
                typePermission.WriteState = defaultState;
                typePermission.CreateState = defaultState;
                typePermission.DeleteState = defaultState;
            }
            PermissionPolicyNavigationPermissionObject navigationPermission = e.CreatedObject as PermissionPolicyNavigationPermissionObject;
            if(navigationPermission != null) {
                SecurityPermissionState defaultState = SecurityPermissionState.Allow;
                if(navigationPermission.Role.PermissionPolicy == SecurityPermissionPolicy.AllowAllByDefault) {
                    defaultState = SecurityPermissionState.Deny;
                }
                navigationPermission.NavigateState = defaultState;
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
