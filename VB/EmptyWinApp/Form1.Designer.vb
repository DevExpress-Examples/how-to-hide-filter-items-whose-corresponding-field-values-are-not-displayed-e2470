Imports Microsoft.VisualBasic
Imports System
Namespace EmptyWinApp
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.productReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productReports = New EmptyWinApp.ProductReports()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductSales = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShippedDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.productReportsTableAdapter = New EmptyWinApp.ProductReportsTableAdapters.ProductReportsTableAdapter()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productReports, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.productReportsBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldProductName, Me.fieldProductSales, Me.fieldShippedDate})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(648, 408)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomFilterPopupItems += New DevExpress.XtraPivotGrid.PivotCustomFilterPopupItemsEventHandler(Me.pivotGridControl1_CustomFilterPopupItems);
			' 
			' productReportsBindingSource
			' 
			Me.productReportsBindingSource.DataMember = "ProductReports"
			Me.productReportsBindingSource.DataSource = Me.productReports
			' 
			' productReports
			' 
			Me.productReports.DataSetName = "ProductReports"
			Me.productReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldProductSales
			' 
			Me.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductSales.AreaIndex = 0
			Me.fieldProductSales.Caption = "Product Sales"
			Me.fieldProductSales.FieldName = "ProductSales"
			Me.fieldProductSales.Name = "fieldProductSales"
			' 
			' fieldShippedDate
			' 
			Me.fieldShippedDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldShippedDate.AreaIndex = 0
			Me.fieldShippedDate.Caption = "Year"
			Me.fieldShippedDate.FieldName = "ShippedDate"
			Me.fieldShippedDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldShippedDate.Name = "fieldShippedDate"
			Me.fieldShippedDate.UnboundFieldName = "fieldShippedDate"
			' 
			' productReportsTableAdapter
			' 
			Me.productReportsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(648, 408)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productReports, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private productReports As ProductReports
		Private productReportsBindingSource As System.Windows.Forms.BindingSource
		Private productReportsTableAdapter As EmptyWinApp.ProductReportsTableAdapters.ProductReportsTableAdapter
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductSales As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShippedDate As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

