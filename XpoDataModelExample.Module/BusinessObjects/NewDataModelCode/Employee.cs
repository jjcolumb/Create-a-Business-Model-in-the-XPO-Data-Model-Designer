using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace XpoDataModelExample.Module.BusinessObjects.NewDataModel
{
    [DefaultClassOptions, ImageName("BO_Employee")]
    public partial class Employee
    {
        public Employee(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
