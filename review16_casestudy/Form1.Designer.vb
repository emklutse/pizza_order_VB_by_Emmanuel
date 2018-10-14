<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpPizzaSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkHotPeppers = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblPizzaPrice = New System.Windows.Forms.Label()
        Me.grpPickup = New System.Windows.Forms.GroupBox()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.radDelivery = New System.Windows.Forms.RadioButton()
        Me.grpPizzaSize.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.grpPickup.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPizzaSize
        '
        Me.grpPizzaSize.Controls.Add(Me.radLarge)
        Me.grpPizzaSize.Controls.Add(Me.radRegular)
        Me.grpPizzaSize.Location = New System.Drawing.Point(72, 68)
        Me.grpPizzaSize.Name = "grpPizzaSize"
        Me.grpPizzaSize.Size = New System.Drawing.Size(437, 133)
        Me.grpPizzaSize.TabIndex = 0
        Me.grpPizzaSize.TabStop = False
        Me.grpPizzaSize.Text = "Select pizza size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(253, 58)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(98, 29)
        Me.radLarge.TabIndex = 1
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(63, 58)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(118, 29)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.chkHotPeppers)
        Me.grpToppings.Controls.Add(Me.chkOnions)
        Me.grpToppings.Controls.Add(Me.chkMushrooms)
        Me.grpToppings.Controls.Add(Me.chkPepperoni)
        Me.grpToppings.Location = New System.Drawing.Point(72, 237)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(437, 231)
        Me.grpToppings.TabIndex = 1
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Select toppings"
        '
        'chkHotPeppers
        '
        Me.chkHotPeppers.AutoSize = True
        Me.chkHotPeppers.Location = New System.Drawing.Point(231, 147)
        Me.chkHotPeppers.Name = "chkHotPeppers"
        Me.chkHotPeppers.Size = New System.Drawing.Size(163, 29)
        Me.chkHotPeppers.TabIndex = 3
        Me.chkHotPeppers.Text = "Hot Peppers"
        Me.chkHotPeppers.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Location = New System.Drawing.Point(231, 68)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(112, 29)
        Me.chkOnions.TabIndex = 2
        Me.chkOnions.Text = "Onions"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Location = New System.Drawing.Point(30, 147)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(145, 29)
        Me.chkMushrooms.TabIndex = 1
        Me.chkMushrooms.Text = "Mushroom"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(30, 68)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(142, 29)
        Me.chkPepperoni.TabIndex = 0
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(72, 648)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(170, 55)
        Me.btnPlaceOrder.TabIndex = 2
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(76, 747)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(166, 50)
        Me.btnNewOrder.TabIndex = 3
        Me.btnNewOrder.Text = "New Orders"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(296, 663)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(0, 25)
        Me.lblOrder.TabIndex = 4
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Location = New System.Drawing.Point(463, 663)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(0, 25)
        Me.lblOrderNumber.TabIndex = 5
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(296, 760)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 25)
        Me.lblPrice.TabIndex = 6
        '
        'lblPizzaPrice
        '
        Me.lblPizzaPrice.AutoSize = True
        Me.lblPizzaPrice.Location = New System.Drawing.Point(463, 760)
        Me.lblPizzaPrice.Name = "lblPizzaPrice"
        Me.lblPizzaPrice.Size = New System.Drawing.Size(0, 25)
        Me.lblPizzaPrice.TabIndex = 7
        '
        'grpPickup
        '
        Me.grpPickup.Controls.Add(Me.radDelivery)
        Me.grpPickup.Controls.Add(Me.radPickup)
        Me.grpPickup.Location = New System.Drawing.Point(71, 511)
        Me.grpPickup.Name = "grpPickup"
        Me.grpPickup.Size = New System.Drawing.Size(437, 112)
        Me.grpPickup.TabIndex = 8
        Me.grpPickup.TabStop = False
        Me.grpPickup.Text = "Pickup"
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Location = New System.Drawing.Point(31, 55)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(108, 29)
        Me.radPickup.TabIndex = 0
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'radDelivery
        '
        Me.radDelivery.AutoSize = True
        Me.radDelivery.Location = New System.Drawing.Point(219, 55)
        Me.radDelivery.Name = "radDelivery"
        Me.radDelivery.Size = New System.Drawing.Size(121, 29)
        Me.radDelivery.TabIndex = 1
        Me.radDelivery.TabStop = True
        Me.radDelivery.Text = "Delivery"
        Me.radDelivery.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 894)
        Me.Controls.Add(Me.grpPickup)
        Me.Controls.Add(Me.lblPizzaPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblOrderNumber)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.grpPizzaSize)
        Me.Name = "Form1"
        Me.Text = "Pizza Order"
        Me.grpPizzaSize.ResumeLayout(False)
        Me.grpPizzaSize.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.grpPickup.ResumeLayout(False)
        Me.grpPickup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpPizzaSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents grpToppings As GroupBox
    Friend WithEvents chkHotPeppers As CheckBox
    Friend WithEvents chkOnions As CheckBox
    Friend WithEvents chkMushrooms As CheckBox
    Friend WithEvents chkPepperoni As CheckBox
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblOrderNumber As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblPizzaPrice As Label
    Friend WithEvents grpPickup As GroupBox
    Friend WithEvents radDelivery As RadioButton
    Friend WithEvents radPickup As RadioButton
End Class
