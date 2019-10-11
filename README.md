# Prove It Works
## Introduction

In this project we're going to take another look at building Mortgage Calculator with decent unit/integration tests.

    Create a local git repository.
    Build a mini version of Mortgage Calculator.
    Write unit tests.
    Add a README.md document.
    Push a branch with latest code up to GitHub..

## High Level Steps

    Initialize the project.
    Review the project files.
    Build a calculator with unit tests.
    Build a mortgage calculator with unit tests.

### Step 1 - Initialize the Project

First, we need to perform the usual, repeatable steps to start a new project. Clone the project from github
### Step 2 - Review the project files

Next, review the files that you have been provided. Notice anything strange?

There's not much here, other than the bare necessities of a React project and a few helpful developer tools. That's because we're going to take a Test-Driven Development approach to rebuilding a miniature version of Mortgage Calculator. We're not introducing a new business need in this project as our focus will be on the testing aspect of software development.

    Atlassian has great content on the ins and outs of software testing at the link pasted below. You should plan to spend a little time reviewing that after completing this project.

### Step 3 - Build a calculator with unit tests
Objectives

We're going to build a simple calculator module and force ourselves to write unit tests before we build the calculator module.

As well as writing tests before code, we will also follow a common process used by developers to write tests called "Red/Green/Refactor". Take a second to read this article, then come back and continue the assignment.

It would be a good idea at this point to stop and take some time to read the documentation/quick start guide c# unit testing before continuing. This will help you become more fluent with the testing syntax and how it works.

Right click in your code and select "Create Unit Tests", then click ok for it to scaffold out a basic test project.
Fill out the CalculatorTests class with this.
```
[TestClass()]
public class CalculatorTests
{
    Calculator calc = new Calculator();

    [TestMethod()]
    public void AddTest()
    {
        double a = 3f;
        double b = 2f;
        double expectedC = 5f;
        double actualC = calc.Add(a, b);
        Assert.AreEqual(expectedC, actualC);
    }
}
```
This code adds a failing unit test. The purpose of this test is to check that the add function in the calculator object exists and behaves as expected.

Open the Tests menu, then select Run->All Tests to run the tests.

The test should fail, which is reasonable as we haven't built a calculator object yet!

Create a new file called Calculator.cs in the main project and add the following code:
```
public void Add()
{
}
```
Try running the tests now. You should see that the first test (the one that checks for the existence of an add function) passes while the second fails. Let's get that test to pass by implementing the add function...
```
public double Add(double a, double b)
{
  return a + b;
}
```
followed by running the tests to make sure the code works.

Now that our tests pass, we should do a brief refactor, following the advice of Red-Green-Refactor.

Then, run the tests to make sure the code still works. This is often called "regression" testing - running tests to make sure you didn't break anything.

Now that we have those two tests passing, it's your turn. Write a subtract, multiply and divide function in Calculator.js in a similar fashion to add, following the Red/Green/Refactor process to write your tests (Write a failing test, then a passing test, then refactor, then repeat).
### Step 4 - Build a Mortgage Calculator constructor function

Next, let's practice writing more tests by encapsulating the mortgage calculation code into it's own module and write 4 accompanying unit tests. Here is some code to get you started:

#### Mortgage.cs  
```
public class Mortgage
{
  public double principal {get; set;}
  public double interest {get; set;}
  public int term {get; set;}
  public int period {get; set;}
  
  public Mortgage(float principal, float interest, int term, int period)
  {
    this.principal = principal;
    this.interest = interest;
    this.term = term;
    this.period = period;
  }
  public double MonthlyPayment()
  {
    double monthlyInterestRate = (interest / 100) / period;
    int numberOfPayments = term * period;
    double compoundedInterestRate = Math.Pow((1 + monthlyInterestRate), numberOfPayments);
    double interestQuotient = (monthlyInterestRate * compoundedInterestRate) / ( (Math.Pow((1 + monthlyInterestRate), numberOfPayments)) - 1);
    double monthlyPayment = principal * interestQuotient;
    return monthlyPayment;
  }
}
```

You will also need to create another TestClass in the test project. Here is some code to get you started:

```
[TestClass()]
public class CalculatorTests
{
    [TestMethod()]
    public void MonthlyPaymentsTest()
    {
        
    }
}
```
test/unit/mortgage.spec.js

const expect = require('chai').expect;
const Mortgage = require('../../src/js/lib/Mortgage');

describe('Mortgage Calculator', () => {

});

Your task is to write at least 4 unit tests
## Exit Criteria

    8 or more unit tests.
    All tests pass when run in the Test Explorer
    Submit your github repository URL using the link at the bottom to navigate to the submission page.
