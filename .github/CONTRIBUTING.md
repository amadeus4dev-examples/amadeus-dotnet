## Development and Testing

To run the project locally, clone the repository.

```
git clone https://github.com/amadeus4dev/amadeus-dotnet.git
cd amadeus-java
```
Download and install visual studio.

Install workloads dependencies.

```
.NET desktop development
Universal Windows Platform development
```

Open project/solution

Install Other dependencies.

```
xunit (Project: amadeus-integration-test)
xunit.runner.visualstudio (Project: amadeus-integration-test)
coverlet.collector (Project: amadeus-integration-test)
Microsoft.AspNetCore.TestHost (Project: amadeus-integration-test)
Microsoft.NET.Test.Sdk (Project: amadeus-integration-test)
System.Runtime.CompilerServices.Unsafe (Project: amadeus-test)
System.Threading.Tasks.Extensions (Project: amadeus-test)
NunitTestAdapter (Project: amadeus-test)
Nunit (Project: amadeus-test)
Castle.Core (Project: amadeus-test)
Moq (Project: amadeus-test)
```

### Running tests

Open Test Explorer.

Click Run All Tests option.


### Building

Open Solution Explorer right click on the project Amadeus and select build.

### Releasing

To make a new release, follow the following steps:

- [ ] Update the `CHANGELOG.md` with the new version
- [ ] Tag your release in git using `git --tag vX.X.X`
- [ ] Push the new tag `git push --tags`
- [ ] Update the [Releases](https://github.com/amadeus4dev/amadeus-dotnet/releases) tab on GitHub with a new release for the tag, copying the description from the `CHANGELOG.md`

## How to contribute to the Amadeus Dotnet SDK

#### **Did you find a bug?**

* **Ensure the bug was not already reported** by searching on GitHub under [Issues](https://github.com/amadeus4dev/amadeus-dotnet/issues).

* If you're unable to find an open issue addressing the problem, [open a new one](https://github.com/amadeus4dev/amadeus-dotnet/issues/new). Be sure to include a **title and clear description**, as much relevant information as possible, and a **code sample** or an **executable test case** demonstrating the expected behavior that is not occurring.

#### **Did you write a patch that fixes a bug?**

* Open a new GitHub pull request with the patch.

* Ensure the PR description clearly describes the problem and solution. Include the relevant issue number if applicable.

#### **Do you intend to add a new feature or change an existing one?**

* Suggest your change [in a new issue](https://github.com/amadeus4dev/amadeus-dotnet/issues/new) and start writing code.

* Make sure your new code does not break any tests and include new tests.

* With good code comes good documentation. Try to copy the existing documentation and adapt it to your needs.

* Close the issue or mark it as inactive if you decide to discontinue working on the code.

#### **Do you have questions about the source code?**

* Ask any question about how to use the library by [raising a new issue](https://github.com/amadeus4dev/amadeus-dotnet/issues/new).
