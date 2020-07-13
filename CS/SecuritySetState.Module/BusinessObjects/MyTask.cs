using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Editors;
using DevExpress.Persistent.Base.General;
using DevExpress.ExpressApp.SystemModule;

namespace SecuritySetState.Module.BusinessObjects {
    [DefaultClassOptions]
    public class MyTask : BaseObject {
        public MyTask(Session session)
            : base(session) {
        }
        public override void AfterConstruction() {
            base.AfterConstruction();
        }
        string subject;
        public string Subject {
            get {
                return subject;
            }
            set {
                SetPropertyValue(nameof(Subject), ref subject, value);
            }
        }
        Contact assignedTo;
        [Association("Contact-Tasks")]
        public Contact AssignedTo {
            get {
                return assignedTo;
            }
            set {
                SetPropertyValue(nameof(AssignedTo), ref assignedTo, value);
            }
        }
        bool isActive;
        public bool IsActive {
            get {
                return isActive;
            }
            set {
                SetPropertyValue(nameof(IsActive), ref isActive, value);
            }
        }
        Priority priority;
        public Priority Priority {
            get {
                return priority;
            }
            set {
                SetPropertyValue(nameof(Priority), ref priority, value);
            }
        }
    }
    public enum Priority {
        [ImageName("State_Priority_Low")]
        Low = 0,
        [ImageName("State_Priority_Normal")]
        Normal = 1,
        [ImageName("State_Priority_High")]
        High = 2
    }
}