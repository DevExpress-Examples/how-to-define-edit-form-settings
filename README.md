<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/398989306/21.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1035063)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Data Grid for WPF - How to Specify Edit Form Settings

This example illustrates how to specify Edit Form settings when a user starts to edit a row. To initialize values or make certain editors read-only, handle the [RowEditStarting](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.RowEditStarting) / [NodeEditStarting](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.NodeEditStarting) event or create a command in a View Model and bind it to the [RowEditStartingCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.RowEditStartingCommand) / [NodeEditStartingCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.NodeEditStarting) property. The event / command arguments contain the **CellEditors** property that returns an array of [CellEditorData](https://docs.devexpress.com/CoreLibraries/DevExpress.Mvvm.CellEditorData) objects. Each object allows you to specify the corresponding editor's settings.

The [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) contains information about employees. The following code sample initializes the **ID** editor (**CellEditors[0]** in code) and disables the **Department** editor (**CellEditors[4]**) for new rows. 

![](/21-2-roweditstarting-example.png)
### Code-Behind

```cs
private void OnRowEditStarting(object sender, RowEditStartingEventArgs e) {
    if(Equals(e.RowHandle, DataControlBase.NewItemRowHandle)) {
        e.CellEditors[0].Value = grid.VisibleRowCount + 1;
        e.CellEditors[4].ReadOnly = true;

    } else {
        e.CellEditors[0].ReadOnly = true;
        e.CellEditors[4].ReadOnly = false;
    }
}
```

### MVVM Pattern
```csharp
[Command]
public void OnRowEditStarting(RowEditStartingArgs args) {
    if(args.IsNewItem) {
        args.CellEditors[0].Value = Employees.Count + 1;
        args.CellEditors[4].ReadOnly = true;

    } else {
        args.CellEditors[0].ReadOnly = true;
        args.CellEditors[4].ReadOnly = false;
    }
}
```

<!-- default file list -->

## Files to Look At

### Code-Behind
- [MainViewModel.xaml.cs](./CS/DefineEditFormSettings_CodeBehind/MainWindow.xaml.cs#L48-L57) ([MainWindow.xaml.vb](./VB/DefineEditFormSettings_CodeBehind/MainWindow.xaml.vb#L91-L99))
- [MainWindow.xaml](./CS/DefineEditFormSettings_CodeBehind/MainWindow.xaml#L13) ([MainWindow.xaml](./VB/DefineEditFormSettings_CodeBehind/MainWindow.xaml#L13))

### MVVM Pattern
- [MainViewModel.cs](./CS/DefineEditFormSettings_MVVM/MainViewModel.cs#L23-L33) ([MainViewModel.vb](./VB/DefineEditFormSettings_MVVM/MainViewModel.vb#L81-L90))
- [MainWindow.xaml](./CS/DefineEditFormSettings_MVVM/MainWindow.xaml#L17) ([MainWindow.xaml](./VB/DefineEditFormSettings_MVVM/MainWindow.xaml#L17))

<!-- default file list end -->

## Documentation

- [Edit Form](https://docs.devexpress.com/WPF/403491/controls-and-libraries/data-grid/data-editing-and-validation/modify-cell-values/edit-form)
- [RowEditStarting](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.RowEditStarting) / [NodeEditStarting](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.NodeEditStarting)
- [RowEditStartingCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.RowEditStartingCommand) / [NodeEditStartingCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.NodeEditStarting)

## More Examples
- [Data Grid for WPF - How to Process Related Cells in the Edit Form](https://github.com/DevExpress-Examples/wpf-data-grid-edit-form-related-cells)
- [Data Grid for WPF - How to Pause Data Updates in the Edit Form](https://github.com/DevExpress-Examples/wpf-data-grid-edit-form-pause-updates)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-specify-edit-form-settings&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-specify-edit-form-settings&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
