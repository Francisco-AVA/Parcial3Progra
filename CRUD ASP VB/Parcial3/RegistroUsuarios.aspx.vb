Imports ENTITY
Imports BLL
Imports DAL
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Class RegistroUsuarios
    Inherits System.Web.UI.Page

    Dim MiUsuario As New ENTITY.ClassUsuario
    Dim buscarUsuario As New DAL.DALUsuario
    Dim modificarUsuario As New DAL.DALUsuario
    Dim eliminarUsuario As New DAL.DALUsuario

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MiUsuario.id = txtID.Text
        MiUsuario.nombre = txtNombre.Text
        MiUsuario.apellido = txtApellido.Text
        MiUsuario.edad = txtEdad.Text
        MiUsuario.telefono = txtTelefono.Text

        Dim bllUsuario As New BLL.ClassBLL

        If bllUsuario.AgregarUsuario(MiUsuario) Then
            lblResultado.Text = "Tu registro " + txtNombre.Text + " se guardo exitosamente"
            limpiar()
        Else
            lblResultado.Text = "Tu registro " + txtNombre.Text + " no se guardo"
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtID.Text = txtID.Text
        txtEdad.Text = 0
        txtTelefono.Text = 0
        buscarUsuario.BuscarUsuario(txtID.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtTelefono.Text)
        lblResultado.Text = "Busqueda realizada exitosamente"
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarUsuario.ModificarUsuario(txtID.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtTelefono.Text)
        limpiar()
        lblResultado.Text = "Se modifico correctamente"
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarUsuario.EliminarUsuario(txtID.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtTelefono.Text)
        limpiar()
        lblResultado.Text = "Se elimino correctamente"
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Sub limpiar()
        txtID.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtEdad.Text = ""
        txtTelefono.Text = ""
    End Sub
End Class
