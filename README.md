# XpoDataModelExample


# Create a Business Model in the XPO Data Model Designer

This topic provides step-by-step instructions on how to use the  [XPO Data Model Designer](https://docs.devexpress.com/XPO/14811/design-time-features/data-model-designer)  in XAF applications. We will create a simple business model consisting of two objects -  **Employee**  and  **Task**. These objects will be linked with a one-to-many relationship. Then you will add XAF-specific attributes in code, and the application will be ready to use.

>NOTE
This designer can also be used to generate a data model for a legacy database (see [How to: Generate XPO Business Classes for Existing Data Tables](https://docs.devexpress.com/eXpressAppFramework/113451/business-model-design-orm/business-model-design-with-xpo/generate-xpo-business-classes-for-existing-data-tables)).

If you prefer to watch a video rather than walk through these step-by-step instructions, you can find the corresponding tutorial on the DevExpress YouTube Channel:  [XAF: Start from Building a Data Model using the XPO Data Model Designer](https://www.youtube.com/watch?v=g3DPsdsonz0).

## Create an XPO Data Model

-   Create a new XAF solution using the  **DevExpress v23.1  XAF Template Gallery**  template.
-   Right-click the  _BusinessObjects_  folder located in the  [module project](https://docs.devexpress.com/eXpressAppFramework/118045/application-shell-and-base-infrastructure/application-solution-components/application-solution-structure)  and choose  **Add**  |  **New Item**. In the invoked  **Add New Item**  dialog, select the  **DevExpress ORM Data Model Wizard**  template located in the  **DevExpress**  category. Set the new item’s name to  **MySolutionDataModel.xpo**  and click  **Add**. You will see that the  _MySolutionDataModel.xpo_  item is added, and the wizard dialog is invoked.
-   In the invoked dialog, select  **Do not connect to a database**  and click  **Next**, to skip the creation of a database connection using the  [XPO Data Model Wizard](https://docs.devexpress.com/XPO/14810/design-time-features/data-model-wizard). The database connection is managed by XAF in your solution.
    
    ![XpoDesigner_CancelWizard](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_cancelwizard117117.png)
    
-   As a result, an empty data model will be shown in the designer.
    
    ![XpoDesigner_EmptyDataModel](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_emptydatamodel117118.png)
    

## Design the Employee Object

-   To add a new business class, drag the  **XpObject**  item from the toolbox to the designer’s surface.
    
    ![XpoDesigner_AddNewClass](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_addnewclass117119.png)
    
-   Focus the newly added object. In the  **Properties**  window, set the object’s  **Name**  to  **Employee**.
    
    ![XpoDesigner_SetClassName](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_setclassname117120.png)
    
-   To add a new persistent property, drag the  **Field**  item from the  **Toolbox**  to the  **Employee**  object.
    
    ![XpoDesigner_AddNewProperty](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_addnewproperty117121.png)
    
-   Focus the newly added field. In the  **Properties**  window, set the field’s  **Name**  to  **FirstName**.
    
    ![XpoDesigner_SetPropertyName](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_setpropertyname117122.png)
    
    Note that the  **Column Type**  is  **String**  by default.
    
-   Repeat the two previous steps to add the  **LastName**  property.
    
    ![XpoDesigner_LastNameProperty](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_lastnameproperty117123.png)
    
-   Now add a field of a type other than string. Add the  **Birthday**  field, and set its  **Column Type**  to  **DateTime**.
    
    ![XpoDesigner_BirthdayProperty](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_birthdayproperty117124.png)
    
-   Next, you will see how to add a calculated field. Drag the  **Persistent Alias**  item from the  **Toolbox**  to the  **Employee**  object.
    
    ![XpoDesigner_AddCalculated](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_addcalculated117129.png)
    
-   Focus the newly added persistent alias. In the  **Properties**  window, set  **Name**  to  **FullName**. Then, click the ellipsis button located to the right of the  **Expression**  setting. In the invoked  **Expression editor**  dialog, specify the  **[FirstName] + ‘ ‘ + [LastName]**  expression and click  **OK**.
    
    ![XpoDesigner_Expression](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_expression117131.png)
    

>NOTE
You can inherit the **Employee** class from the **DevExpress.Persistent.BaseImpl.Person** class, instead of creating it from scratch. The **XPO Data Model Designer** supports the use of persistent classes from external assemblies as base classes and property types. To add business classes from the [Business Class Library](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces) (or your own class library), do the following.

-   Right-click the free space on the design surface. In the invoked context menu, choose **Add Assembly**.
-   Select the assembly that contains business classes and click **Open**. You can choose the _DevExpress.Persistent.BaseImpl.Xpo.v23.1.dll_ assembly that ships with XAF, located in the _%PROGRAMFILES%\DevExpress 23.1\Components\Bin\Framework_ path, or your custom assembly.
-   In the **Select Types** dialog, choose the persistent classes to import from the assembly and click **OK**.

These actions will import classes in read-only mode. Only persistent fields are displayed for these classes, and reference property types correspond to the underlying database types. However, you will be able to use the added classes as ancestors, and inherit new persistent classes from them in the Designer. To specify inheritance, select the **Inheritance** item in the **Toolbox** and draw a line from a descendant to a base class. Additionally, you will be able to use these classes as property types.

## Design the Task Object

-   To add another business class, drag the  **XpObject**  item from the toolbox to the designer’s surface. Focus the newly added object. In the  **Properties**  window, set the object’s  **Name**  to  **Task**.
    
    ![XpoDesigner_AddTask](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_addtask117125.png)
    
-   Add the  **Subject**  and  **Description**  persistent properties of the string type using the approach described in the  **Design the Employee Object**  section.
    
    ![XpoDesigner_AddTaskProperties](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_addtaskproperties117127.png)
    
-   Next, see how to apply attributes to persistent properties. Focus the  **Description**  field. In the  **Properties**  window, expand the  **DBType**  category, and set  **Size**  to  **Unlimited**.
    
    ![XpoDesigner_DescriptionSize](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_descriptionsize117128.png)
    
    As a result, the  [SizeAttribute](https://docs.devexpress.com/XPO/DevExpress.Xpo.SizeAttribute)  will be applied to the  **Description**  property in the underlying code. The attribute’s parameter will be set to  **SizeAttribute.Unlimited**.
    

## Add a One-to-Many Association

-   Add the  **AssignedTo**  persistent property of the  **Employee**  type to the  **Task**  class. This property will represent the “one” part of the one-to-many association.
    
    ![XpoDesigner_AddAssignedTo](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_addassignedto117132.png)
    
-   In the  **Toolbox**, focus the  **Association Object**  item. Draw a line from  **Employee**  to  **Task**, to create the association.
    
    ![XpoDesigner_Association](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_association117133.png)
    
    >NOTE
    Alternatively, you can use the **XpObject**‘s title bar context menu to create an association. For details, refer to the **Association** section of the [Data Model Designer](https://docs.devexpress.com/XPO/14811/design-time-features/data-model-designer) topic.
    
-   Save the changes and close the designer.

## Add XAF-Specific Attributes in Code

-   In the  **Solution Explorer**, expand the  _BusinessObjects\MySolutionDataModelCode_  folder. This folder contains the code generated by the designer. Open the  _Employee.cs_  (_Employee.vb_) file. Decorate the  **Employee**  class with the  [DefaultClassOptionsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DefaultClassOptionsAttribute)  and  [ImageNameAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ImageNameAttribute)  attributes to the  **Employee**  object. As a result, the  **Employee**  object will be added to the  [Navigation System](https://docs.devexpress.com/eXpressAppFramework/113198/application-shell-and-base-infrastructure/navigation-system), and an icon from the built-in library will be associated with this object.
    

    
    ```csharp
    using DevExpress.Persistent.Base;
    // ...
    [DefaultClassOptions, ImageName("BO_Employee")]
    public partial class Employee {
        public Employee(Session session) : base(session) { }
        public Employee() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    
    ```
    
-   Open the  _Task.cs_  (_Task.vb_) file. Decorate the  **Task**  class with the  **DefaultClassOptions**  and  **ImageName**  attributes.
    

    
    ```csharp
    using DevExpress.Persistent.Base;
    // ...
    [DefaultClassOptions, ImageName("BO_Task")]
    public partial class Task {
        public Task(Session session) : base(session) { }
        public Task() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    
    ```
    

>NOTE
You can add more custom code to the auto-generated classes (e.g., [add Action methods](https://docs.devexpress.com/eXpressAppFramework/112619/ui-construction/controllers-and-actions/actions/how-to-create-an-action-using-the-action-attribute) or override base class methods). Do not change the code located in files with the _designer_ suffix - they contain designer-generated code, and should not be modified manually. The classes generated are declared as _partial_. Designed and custom class parts are located in different files.

>IMPORTANT
You cannot apply attributes to properties in the partial class’ code. Instead, use the designer (see the next section).

## Add XAF-Specific Attributes in the Designer

Alternatively, you can use the designer to apply attributes. Focus the required class or field and specify the  **Custom Attributes**  setting in the  **Properties**  window.

![CustomAttributes](https://docs.devexpress.com/eXpressAppFramework/images/customattributes132225.png)

## Run the Application

Now you can run the Windows Forms and ASP.NET Web Forms applications to see the result. These applications are completely based on the business model specified in the XPO Data Model Designer.

-   **Windows Forms**
    
    ![XpoDesigner_RuntimeWin](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_runtimewin117134.png)
    
-   **ASP.NET Web Forms**
    
    ![XpoDesigner_RuntimeWeb](https://docs.devexpress.com/eXpressAppFramework/images/xpodesigner_runtimeweb117135.png)
