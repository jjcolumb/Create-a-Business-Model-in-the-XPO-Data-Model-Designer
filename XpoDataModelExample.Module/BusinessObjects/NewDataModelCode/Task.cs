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
    [DefaultClassOptions, ImageName("BO_Task")]
    public partial class Task
    {
        public Task(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
