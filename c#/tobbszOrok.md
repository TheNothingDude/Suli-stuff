# Tobbszoros orokles

- **c#ban nincs** (c++ van)

```c#
abstact class Negyszog
{
    abstract double Terulet(){}
}

class Teglalap : Negyszog
{
    double Tertulet(){}
}

class Rombusz : Negyszog
{
    double Terulet()
}

class Negyzet : Telalap && Rombusz //(not acc syntax)
```

## Gyemant forma problema

![problemo](https://media.geeksforgeeks.org/wp-content/uploads/20240603173048/diamond-problem-in-cpp.webp)

# Interface

- hasonlo mint egy abstract osztaly
- csak methodusokat ir elo:
  - Mit kell csinalni
  - **De azt nem, hogy hogyan**
- Nics benne tagvaltozo
- Egy osztaly **megvalosit** egy interface-t
- Methodusok lathatosaga mindig public
  - abtract methoduskent viselkedik :smirk:

```c#
public interface IFunction
{
    double Fgv(double x);
}

public class Sin : IFunction
{
    public double Fgv(double x)
    {
        return Math.Sin(x);
    }
}

Sin s = new Sin();
s.Fgv(0.5);
```
