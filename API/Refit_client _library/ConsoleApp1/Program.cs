using ClassLibrary1;
using ClassLibrary1.Interface;
using Refit;

string baseAddress = "http://localhost:5278";
var userAPI = RestService.For<IUserService>(baseAddress);

var users = await userAPI.GetUsersAsync();
await userAPI.PostAsync(userDTO: new UserDTO { Id = 74, FirstName = "Mazaher",LastName="Masoumi" });

foreach (var user in users)
{
    Console.WriteLine($"{user.Id}  : {user.FirstName} {user.LastName}");
}

