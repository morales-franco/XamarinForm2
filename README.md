# XamarinForm2
Segunda sesión SQLite

Se utiliza la ultima versión de :
SQLiteNetExtensions
SQLiteNetExtensions.Async

Estas versiones extienden:
SQLite.SQLiteConnection y NO SQLite.Net.SQLiteConnection como en el ejemplo original.
 
Por lo tanto NO podemos utilizar:
var Conexion = new SQLite.Net.SQLiteConnection(_plataforma, _rutaBD,SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create| SQLiteOpenFlags.FullMutex, true);


Lo que hicimos fue utilizar un connection de clase SQLite.SQLiteConnection, pero este NO tiene un constructor que soporte la plataforma. Asique NO le estamos pasando la plataforma como parametro para crear la BD.
Esto esta testeado en ANDROID y fue bien.

