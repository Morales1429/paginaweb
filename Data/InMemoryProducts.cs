namespace paginaweb.Data;

public class InMemoryProducts
{
    
    private List<string> Codes = new List<string>{
        "0A0001", "0G0007", "0M0013",
        "0B0002", "0H0008", "0N0014",
        "0C0003", "0I0009", "0O0015",
        "0D0004", "0J0010", "0P0016",
        "0E0005", "0K0011", "0Q0017",
        "0F0006", "0L0012", "0R0018",
    };

    private List<string> Names = new List<string>{
        "Faja Short", "Faja Moldeadora Doble", "Lapiz Blanqueador", 
        "Maquina 40 3 en 1", "Manguera Expandible", "Cinturilla Termoreductora", 
        "Maquina 2x1 paga 1 lleva 2", "Depiladora Facial", "Candado Alarma", 
        "Bafle Ducha", "Reloj Inteligente", "Maquina 3x1","Ridex MataInsectos", 
        "Shampo cubre canas", "Cepillo facial 5 en 1", "Combo Baby liss 3 en 1",
        "Carbon Activado ", "Cinta Flex", "Mini Aro de Luz","Laser Blanqueador","Purificador de agua",
        "Tonificador de Abdomen","Short Realce Cola","Extrartor de Espinillas","Ahorrador de Agua"
    };

    public List<Product> getProducts ()
    {
        List<Product> ListProducts = new ();
        Random random = new Random();
        for(var i = 0; i < 18; i++) {
            Product product = new Product {
                    id = i+1,
                    Code = this.Codes[i],
                    Name = this.Names[i],
                    Price = random.Next(1000000)
            };
            ListProducts.Add(product);
        }

        return ListProducts;
    }
}