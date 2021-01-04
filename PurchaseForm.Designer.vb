<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseForm))
        Me.dgvProductTable = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProducttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSystemDataSet = New Cashiering_System01.CSystemDataSet()
        Me.ProducttblTableAdapter = New Cashiering_System01.CSystemDataSetTableAdapters.ProducttblTableAdapter()
        Me.lblProductList = New System.Windows.Forms.Label()
        Me.dgvOrderList = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblOrderList = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.tbxPayment = New System.Windows.Forms.TextBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        CType(Me.dgvProductTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProducttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProductTable
        '
        Me.dgvProductTable.AutoGenerateColumns = False
        Me.dgvProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.dgvProductTable.DataSource = Me.ProducttblBindingSource
        Me.dgvProductTable.Location = New System.Drawing.Point(12, 77)
        Me.dgvProductTable.MultiSelect = False
        Me.dgvProductTable.Name = "dgvProductTable"
        Me.dgvProductTable.Size = New System.Drawing.Size(343, 268)
        Me.dgvProductTable.TabIndex = 0
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'ProducttblBindingSource
        '
        Me.ProducttblBindingSource.DataMember = "Producttbl"
        Me.ProducttblBindingSource.DataSource = Me.CSystemDataSetBindingSource
        '
        'CSystemDataSetBindingSource
        '
        Me.CSystemDataSetBindingSource.DataSource = Me.CSystemDataSet
        Me.CSystemDataSetBindingSource.Position = 0
        '
        'CSystemDataSet
        '
        Me.CSystemDataSet.DataSetName = "CSystemDataSet"
        Me.CSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProducttblTableAdapter
        '
        Me.ProducttblTableAdapter.ClearBeforeFill = True
        '
        'lblProductList
        '
        Me.lblProductList.AutoSize = True
        Me.lblProductList.BackColor = System.Drawing.Color.Tan
        Me.lblProductList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductList.Location = New System.Drawing.Point(12, 40)
        Me.lblProductList.Name = "lblProductList"
        Me.lblProductList.Size = New System.Drawing.Size(107, 24)
        Me.lblProductList.TabIndex = 1
        Me.lblProductList.Text = "Product List"
        '
        'dgvOrderList
        '
        Me.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.clmProductName, Me.clmPrice, Me.Quantity, Me.TotalPrice})
        Me.dgvOrderList.Location = New System.Drawing.Point(397, 77)
        Me.dgvOrderList.MultiSelect = False
        Me.dgvOrderList.Name = "dgvOrderList"
        Me.dgvOrderList.Size = New System.Drawing.Size(439, 268)
        Me.dgvOrderList.TabIndex = 2
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "clmProductID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.Visible = False
        '
        'clmProductName
        '
        Me.clmProductName.HeaderText = "ProductName"
        Me.clmProductName.Name = "clmProductName"
        '
        'clmPrice
        '
        Me.clmPrice.HeaderText = "Price"
        Me.clmPrice.Name = "clmPrice"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "clmQuantity"
        Me.Quantity.Name = "Quantity"
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "clmTotalPrice"
        Me.TotalPrice.Name = "TotalPrice"
        '
        'lblOrderList
        '
        Me.lblOrderList.AutoSize = True
        Me.lblOrderList.BackColor = System.Drawing.Color.Tan
        Me.lblOrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderList.Location = New System.Drawing.Point(393, 40)
        Me.lblOrderList.Name = "lblOrderList"
        Me.lblOrderList.Size = New System.Drawing.Size(91, 24)
        Me.lblOrderList.TabIndex = 3
        Me.lblOrderList.Text = "Order List"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Tan
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(720, 373)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(93, 24)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total : P 0"
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BackColor = System.Drawing.Color.Tan
        Me.btnAddOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAddOrder.Location = New System.Drawing.Point(236, 364)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(96, 45)
        Me.btnAddOrder.TabIndex = 5
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.Firebrick
        Me.btnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.btnRemoveItem.Location = New System.Drawing.Point(397, 364)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(122, 45)
        Me.btnRemoveItem.TabIndex = 6
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.Green
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(717, 452)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(96, 45)
        Me.btnCheckout.TabIndex = 7
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'tbxPayment
        '
        Me.tbxPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.tbxPayment.Location = New System.Drawing.Point(539, 421)
        Me.tbxPayment.MinimumSize = New System.Drawing.Size(60, 30)
        Me.tbxPayment.Name = "tbxPayment"
        Me.tbxPayment.Size = New System.Drawing.Size(87, 29)
        Me.tbxPayment.TabIndex = 8
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.BackColor = System.Drawing.Color.Tan
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(421, 427)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(98, 24)
        Me.lblPayment.TabIndex = 9
        Me.lblPayment.Text = "Payment : "
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.BackColor = System.Drawing.Color.Tan
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(421, 473)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(119, 24)
        Me.lblChange.TabIndex = 10
        Me.lblChange.Text = "Change : P 0"
        '
        'PurchaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(848, 514)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.tbxPayment)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblOrderList)
        Me.Controls.Add(Me.dgvOrderList)
        Me.Controls.Add(Me.lblProductList)
        Me.Controls.Add(Me.dgvProductTable)
        Me.Name = "PurchaseForm"
        Me.Text = "Purchase"
        CType(Me.dgvProductTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProducttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductTable As DataGridView
    Friend WithEvents CSystemDataSetBindingSource As BindingSource
    Friend WithEvents CSystemDataSet As CSystemDataSet
    Friend WithEvents ProducttblBindingSource As BindingSource
    Friend WithEvents ProducttblTableAdapter As CSystemDataSetTableAdapters.ProducttblTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblProductList As Label
    Friend WithEvents dgvOrderList As DataGridView
    Friend WithEvents lblOrderList As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents clmProductName As DataGridViewTextBoxColumn
    Friend WithEvents clmPrice As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents tbxPayment As TextBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblChange As Label
End Class
