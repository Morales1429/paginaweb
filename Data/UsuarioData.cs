namespace paginaweb.Data;

public class UsuarioData
{
    private List<string> Nombre = new List<string>(){
        
    };

    private List<string> Correo = new List<string>(){
        
    };
    private List<string> Mensaje = new List<string>(){
        
    };

    private List<string> Numero = new List<string>(){
        
    };
   
    public List<Usuario> GetUsuarios ()
    {
        List<Usuario> ListUsuario = new ();
    
        
            Usuario item = new Usuario {
                Correo = this.Correo.ToString(),
                Nombre = this.Nombre.ToString(),
                Mensaje = this.Mensaje.ToString(),
                Numero = this.Numero.ToString()
            };
            ListUsuario.Add(item);
        

        return ListUsuario;
    }
}