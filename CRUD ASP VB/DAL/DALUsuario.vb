Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web
Imports ENTITY
Public Class DALUsuario

    Dim cnn As New SqlClient.SqlConnection(Conexion.cadcon)

    Public Function AgregarUsuario(MiUsuario As ENTITY.ClassUsuario) As Boolean
        Dim cnn As New SqlConnection(DAL.Conexion.cadcon)
        Dim cmd As New SqlCommand("insertarUsuario", cnn)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("id", SqlDbType.Int).Value = MiUsuario.id
        cmd.Parameters.Add("nombre", SqlDbType.NVarChar, 50).Value = MiUsuario.nombre
        cmd.Parameters.Add("apellido", SqlDbType.NVarChar, 50).Value = MiUsuario.apellido
        cmd.Parameters.Add("edad", SqlDbType.Int).Value = MiUsuario.edad
        cmd.Parameters.Add("telefono", SqlDbType.Int).Value = MiUsuario.telefono

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        cnn.Close()
    End Function

    Public Sub ModificarUsuario(ByVal id As Integer, ByRef nombre As String, ByRef apellido As String, ByRef edad As Integer, ByRef telefono As String)
        Dim cnn As New SqlClient.SqlConnection(Conexion.cadcon)
        Dim cmd As New SqlClient.SqlCommand("modificarUsuario", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("id", SqlDbType.Int).Value = id
        cmd.Parameters.Add("nombre", SqlDbType.NVarChar, 50).Value = nombre
        cmd.Parameters.Add("apellido", SqlDbType.NVarChar, 50).Value = apellido
        cmd.Parameters.Add("edad", SqlDbType.Int).Value = edad
        cmd.Parameters.Add("telefono", SqlDbType.Int).Value = telefono

        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        cnn.Close()
    End Sub

    Public Sub BuscarUsuario(ByVal id As Integer, ByRef nombre As String, ByRef apellido As String, ByRef edad As Integer, ByRef telefono As String)
        Dim cnn As New SqlClient.SqlConnection(Conexion.cadcon)
        Dim cmd As New SqlClient.SqlCommand("buscarUsuario", cnn)
        cmd.Parameters.Add("id", SqlDbType.Int).Value = id
        cmd.CommandType = CommandType.StoredProcedure
        Try
            cnn.Open()
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                nombre = dr(0).ToString
                apellido = dr(1).ToString
                edad = dr(2).ToString
                telefono = dr(3).ToString

            End If
            cmd.ExecuteNonQuery()
            dr.Close()

        Catch ex As Exception
        End Try
        cnn.Close()
    End Sub

    Public Sub EliminarUsuario(ByVal id As Integer, ByRef nombre As String, ByRef apellido As String, ByRef edad As Integer, ByRef telefono As String)
        Dim cnn As New SqlClient.SqlConnection(Conexion.cadcon)
        Dim cmd As New SqlClient.SqlCommand("eliminarUsuario", cnn)
        cmd.Parameters.Add("id", SqlDbType.Int).Value = id
        cmd.CommandType = CommandType.StoredProcedure
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        cnn.Close()
    End Sub

End Class
