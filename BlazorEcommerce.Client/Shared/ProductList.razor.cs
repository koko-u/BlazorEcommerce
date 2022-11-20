using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Shared;

public partial class ProductList
{
    private readonly IEnumerable<Product> Products = new List<Product>()
    {
        new()
        {
            Id = Guid.Parse("14b453fc-542b-45a8-a300-c54438a2903e")
          , Title = "The Hitchhiker's Guide to the Galaxy"
          , Description =
                @"The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film."
          , ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg"
          , Price = 9.99m
        }
      , new()
        {
            Id = Guid.Parse("3702fa21-c04a-4bce-a88c-557b1ed86719")
          , Title = "Ready Player One"
          , Description =
                @"Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune."
          , ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg"
          , Price = 7.99m
        }
      , new()
        {
            Id = Guid.Parse("d45e8d16-0fc9-425e-b605-6c651c3169f4")
          , Title = "Nineteen Eighty-Four"
          , Description =
                @"Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by the English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime."
          , ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/400px-1984first.jpg"
          , Price = 6.99m
        }
    };
}