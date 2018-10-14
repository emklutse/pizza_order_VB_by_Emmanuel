Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Const REGULAR As Decimal = 6
        Const LARGE As Decimal = 10
        Const ONE_TOPPINGS As Decimal = 1
        Const TWO_TOPPINGS As Decimal = 1.75
        Const THREE_TOPPINGS As Decimal = 2.5
        Const FOUR_TOPPINGS As Decimal = 3.25
        Const pickup As Decimal = 0
        Const delivery As Decimal = 1.5
        Static orderNumber As Integer = 0
        Dim numToppings As Integer = 0
        Dim toppingsPrice As Decimal = 0
        Dim pizzaPrice As Decimal = 0

        'Increment order number
        orderNumber += 1

        'Count selected toppings
        If Me.chkHotPeppers.Checked = True Then
            numToppings += 1
        End If
        If Me.chkMushrooms.Checked = True Then
            numToppings += 1
        End If
        If Me.chkOnions.Checked = True Then
            numToppings += 1
        End If
        If Me.chkPepperoni.Checked = True Then
            numToppings += 1
        End If

        'Determing toppings price
        Select Case numToppings
            Case 1
                toppingsPrice = ONE_TOPPINGS
            Case 2
                toppingsPrice = TWO_TOPPINGS
            Case 3
                toppingsPrice = THREE_TOPPINGS
            Case 4
                toppingsPrice = FOUR_TOPPINGS
        End Select

        'Determine Pizza Price
        If Me.radLarge.Checked Then
            pizzaPrice = LARGE + toppingsPrice
        Else
            pizzaPrice = REGULAR + toppingsPrice
        End If

        If Me.radDelivery.Checked Then
            pizzaPrice = delivery + toppingsPrice
        Else
            pizzaPrice = pickup + toppingsPrice
        End If

        'Display order number and pizza price
        Me.lblOrder.Text = "Order Number:"
        Me.lblOrderNumber.Text = orderNumber
        Me.lblPrice.Text = "Price: $"
        Me.lblPizzaPrice.Text = pizzaPrice
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        Me.radLarge.Checked = False
        Me.radRegular.Checked = True
        Me.chkHotPeppers.Checked = False
        Me.chkMushrooms.Checked = False
        Me.chkOnions.Checked = False
        Me.chkPepperoni.Checked = False
        Me.radPickup.Checked = False
        Me.radDelivery.Checked = False
        Me.lblOrder.Text = Nothing
        Me.lblOrderNumber.Text = Nothing
        Me.lblPrice.Text = Nothing
        Me.lblPizzaPrice.Text = Nothing
    End Sub
End Class
