# PizzaBox

The goal of the project is to build a Pizza Ordering System.

## Architecture [REQUIRED]

+ [solution] PizzaBox.sln
  + [project - console] PizzaBox.Client.csproj
  + [project - classlib] PizzaBox.Domain.csproj
    + [folder] Abstracts
    + [folder] Interfaces
    + [folder] Models
  + [project - classlib ] PizzaBox.Storing.csproj
    + [folder] Repositories
  + [project - xunit] PizzaBox.Testing.csproj
    + [folder] Tests

## Requirements

The project should support objects of Customer, Store, Order, Pizza.

### store

+ [required] there should exist at least 2 stores for a user to choose from
+ [required] each store should be able to view/list any and all of their completed/placed orders
+ [required] each store should be able to view/list any and all of their sales (amount of revenue weekly or monthly)

### order

+ [required] each order must be able to view/list/edit its collection of pizzas
+ [required] each order must be able to compute its pricing
+ [required] each order must be limited to a total pricing of no more than $250
+ [required] each order must be limited to a collection of pizzas of no more than 50

### pizza

+ [required] each pizza must be able to have a crust
+ [required] each pizza must be able to have a size
+ [required] each pizza must be able to have toppings
+ [required] each pizza must be able to compute its pricing
+ [required] each pizza must have no less than 2 default toppings
+ [required] each pizza must limit its toppings to no more 5

### user

+ [required] must be able to view/list its order history
+ [required] must be able to only order from 1 location in a 24-hour period with no reset
+ [required] must be able to only order once every 2-hour period

## technologies

+ .NET Core - C#
+ .NET Core - EF + SQL
+ .NET Core - xUnit

## timelines

+ due on _April 12_  at 11:59p Eastern (CODE FREEZE)
+ present on _April 14_ starting at 9.30a Central
+ implement as many requirements as you can (don't push to get all done)
+ expect mvp status for the project:
  - able to order at least 1 pizza
  - order should be saved in DB
  - order should be retrieved back to UI
  - should implement unit testing

## As a Customer

+ should be able to launch the application
+ should be able to view a list of available stores
+ should be able to select a store
+ should be able to place an order
+ order should be either a custom pizza or a preset pizzas
+ if a custom pizza is selected
  + should be able to select a crust, a size and a set of toppings
+ if a preset pizza is selected
  + should be able to select a pizza, a size 
+ should be able to view order
+ should be able to add or remove pizzas
+ should be able to checkout the order
+ should be able to view the order history
+ should be able to make new order

## As a Store

+ should be able to access the application
+ should be able to view an options menu for order history and sales report
+ should be able to select an option
+ select options for all store orders and orders associated to a user (filtering)
+ if sales
+ see pizza type, count, revenue by week or by month

> the goal is to try to complete as many reqs as you can in the time alloted. :)
