# HoroLogica - An online Swiss Watch Retailer

HoroLogica is an online retailer for luxurios and premium swiss watches. This retailer had a vision in mind, to create a shopping experience
for watches where the location or visiting a store isnt necessary

## Getting Started

To run the application on your machine and do some code overview:

1. Ensure you have Visual Studio installed.
2. Within it install WPF and the .Net 8.0 FrameWork (Latest stable framework).
3. Make sure you have Microsoft SQL Server Management Studio installed to manage data within a database.
4. Clone or download the [HoroLogica_E-Commerce_App] (https://github.com/MQZakir/HoroLogica_E-Commerce_App) on your machine.
5. Open the solution file in Visual Studio (will be labeled as a .sln file).
6. Set up the database connection in SQL Server Management Studio
   (View -> Server Explorer, Add Database Connection -> Microsoft SQL Server).
7. Build the solution and run the project in Visual Studio.

To just run the application on your machine:

1. Open the folder named 'HoroLogica_App'.
2. Direct to bin -> Debug -> net8.0-windows -> SWE5201_AssingmentV3.exe

## Application Overview

### Home Page

- Main Window with buttons to different pages.
- Exclusive collections only accessible from home page.

### Collections Page

- Different views or Grids for men and women collection.
- Users can view the rending watches for noth genders and add watches to their bag.
- Users can navigate to other pages via the side nav-bar.

### Brands Page

- Users can view brands offered at the store.

### Search Page

- Upon user entering a keyword, search algorithm runs.
- User can view the product results with scrollable feature.
- User can type in any keyword to get reults.
- User will be prompted if results were not found.

### Shopping Bag Page

- Users can view their watches added within the bag with scrollable feature.
- If user is a guest then upon closing the app will empty the bag, else will show the items once they log back in
- User can decide to increase watch quantity (Inventory search takes place to make sure of stock)
- Users can delete an item from the bag.

### About Page

- Displays the Story, Mission, and Values of HoroLogica.
- Button to go to the collections page

### Support Page

- Showcases available books with details and an "Add to Cart" button.
- Allows users to add books to their shopping cart.
- Features navigation tabs for seamless browsing.

### Login Page

- Users can log in if previously registered.
- Authentication algoithm runs to authenticate user.
- The registration, and reste password forms are baked on top of the login oage for ease of accessibility.
- If user has forgotten their password, they can proceed to reset their password.
- If new user, they can register by filling out the registration form.
- Registration process runs to validate every input from the user.
- Once registered/login, user is directed to the home page, with the login button switching to the profile button dynamically.

### Profile Page

- User can view their profile.
- USer can make any changes to their profile.
- Update queries run to update data for the user.

### Product Pages
- Users can view a single product's information in detail.
- Page shows brand, model, description, and price.
- User can decide to add the product to cart (Inventory check runs to make sure of stock)

### Colours used: 
- Primary -> #FF101113
- Secondary -> #FF25262B
- Text -> #FFFFFFFF
- Accents -> #FFFF8134, #FF2D2D2D, #FFC8C8C8


## Contributors

- Any contributions to the HoroLogica's E-Commerce system are welcome.
- Constructive feedback is much appreciated.
- Any bugs or suggestions? Please open an issue or submit a pull request.

## Acknowledgments

- [C#] - Powerful programming language used for developing the backend logic of this project.
- [.NET 8.0] - Framework providing a rich set of libraries and tools for building robust applications.
- [WPF] - Technology used for creating the user interface of this application.
- [Visual Studio] - Integrated development environment (IDE) that greatly facilitated the development process.
- [Microsoft SQL Server Management Studio] - Efficient tool for managing the database backend of this system.
 
