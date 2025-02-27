# COFFEE MANAGER

<p align="center">
  <img src="https://github.com/taovietducofficial/Coffee-Winform-Management/blob/master/Picture2.png" width="1000" />
</p>

A coffee shop requires the design of an application to manage the sales of its beverages with the following basic requirements:

The shop will have multiple employees working. Employees are divided into two main groups: managers and staff. Each employee will be assigned a unique employee ID and password to log into the system, knowing that the employee account will be automatically created after successfully entering the employee's information. Staff members sell beverages and have the ability to create invoices for customers. Customers can own multiple invoices. Each invoice will contain a list of beverages that the customer has purchased. Only employees with managerial roles can add ingredients to the inventory. Beverages will be categorized into different types. Additionally, the coffee shop should be able to add new beverage types and remove slow-selling or out-of-stock beverages. Moreover, revenue statistics are required on a monthly, quarterly, and yearly basis.


## The following information needs to be stored:

- For accounts: Employee ID, password, and role.

- For employees: Employee ID, full name, national identification number (12 digits), role ID, phone number, address, date of birth, age, and work status.

- For customers: Phone number, full name, and address.

- For invoices: Invoice ID, employee ID (who created the invoice), customer ID, and invoice issuance time.

- For beverage list: Invoice ID, product ID, and quantity.
  
- For inventory: Ingredient ID and the amount of ingredient in stock.
  
- For ingredient categories: List of ingredient types in stock and their corresponding category IDs.
  
- For ingredients: Ingredient ID, ingredient name, category ID, purchase price, and unit price.
  
- For beverage list: Invoice ID, beverage ID, and beverage quantity.

## Permissions:
The coffee shop management system (for managing coffee sales) is primarily used by store managers (Managers) and service staff (Staff).

- Manager Group

- Staff Group
## Main Functions:
### For the Manager Group:
- CRUD[1] beverage types: Create, delete, update, and manage beverage data in the database.

- CRUD[1] staff accounts: Assign accounts to staff, delete, update staff information, and manage staff access rights.

- CRUD[1] customer accounts: Create new customers, add, delete, update, and retrieve customer information.

- Calculate store profits on a daily, monthly, or yearly basis.

- Stock management: Add ingredients to inventory, including quantity and type of ingredients, and manage ingredient information in stock.

### For the Staff Group:
#### Search and create customer accounts:

- Create a new loyal customer account.

- Search for a customer in the system.

- Cannot delete customers; deletion requires manager permissions.

#### Search and create purchase orders:

- Create a new purchase order or search for any existing order.

#### Search ingredient information:

- Check the remaining quantity of ingredients in stock or retrieve information about any ingredient.
  
## [1] CRUD: Create, Read, Update, Delete.
