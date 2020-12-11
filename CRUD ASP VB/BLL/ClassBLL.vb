Public Class ClassBLL

    Dim MiDalUsuario As New DAL.DALUsuario
    Public Function AgregarUsuario(MiUsuario As ENTITY.ClassUsuario) As Boolean
        Return MiDalUsuario.AgregarUsuario(MiUsuario)
    End Function

End Class
