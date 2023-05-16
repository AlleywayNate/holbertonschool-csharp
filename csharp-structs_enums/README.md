# 0x05. C# - Structs, Enumerations
## Tasks

### 0. They're good dogs

Define a new enum  `Rating`  with the values  `Good`,  `Great`,  `Excellent`.

##### Expected output with [`0-main.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x05-csharp-structs_enums/0-dog/0-main.cs)
```
Titania792@ubuntu:~/0x05-csharp-structs_enums\0-dog$ ls
bin    obj    0-dog.cs    0-dog.csproj    0-main.cs
Titania792@ubuntu:~/0x05-csharp-structs_enums\0-dog$ dotnet run
Score: Great
Score: 1
Titania792@ubuntu:~/0x05-csharp-structs_enums\0-dog$

```

-   Directory:  [`0-dog/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x05-csharp-structs_enums/0-dog)
-   File:  [`0-dog.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x05-csharp-structs_enums/0-dog/0-dog.cs)


### 1. Chief Puppy Officer

Based on  `0-dog`, define a new struct  `Dog`  with the following members:

-   `name`, type:  `public string`
-   `age`, type:  `public float`
-   `owner`, type:  `public string`
-   `rating`, type  `public Rating`

##### Expected output with [`1-main.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x05-csharp-structs_enums/1-dog/1-main.cs)
```
Titania792@ubuntu:~/0x05-csharp-structs_enums\1-dog$ ls
bin    obj    1-dog.cs    1-dog.csproj    1-main.cs
Titania792@ubuntu:~/0x05-csharp-structs_enums\1-dog$ dotnet run
My name is Poppy and I am 0.7. I am an Excellent dog. :)
Titania792@ubuntu:~/0x05-csharp-structs_enums\1-dog$

```

-   Directory:  [`1-dog/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x05-csharp-structs_enums/1-dog)
-   File:  [`1-dog.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x05-csharp-structs_enums/1-dog/1-dog.cs)


### 2. A dog is the only thing on earth that loves you more than you love yourself


Based on  `1-dog`, add a constructor to struct  `Dog`  that takes parameters.

##### Expected output with [`2-main.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x05-csharp-structs_enums/2-dog/2-main.cs)
```
Titania792@ubuntu:~/0x05-csharp-structs_enums\2-dog$ ls
bin    obj    2-dog.cs    2-dog.csproj    2-main.cs
Titania792@ubuntu:~/0x05-csharp-structs_enums\2-dog$ dotnet run
My name is Poppy and I am 0.7. I am an Excellent dog. :)
Titania792@ubuntu:~/0x05-csharp-structs_enums\2-dog$

```

-   Directory:  [`2-dog/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x05-csharp-structs_enums/2-dog)
-   File:  [`2-dog.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x05-csharp-structs_enums/2-dog/2-dog.cs)


### 3. A dog will teach you unconditional love. If you can have that in your life, things won't be too bad

Based on  `2-dog`, override the  `.ToString()`  method to print the Dog object’s attributes to stdout.

Format:

```
Dog Name: <name>
Age: <age>
Owner: <owner>
Rating: <rating>
```
##### Expected output with [`3-main.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x05-csharp-structs_enums/3-dog/3-main.cs)
```
Titania792@ubuntu:~/0x05-csharp-structs_enums\3-dog$ ls
bin    obj    3-dog.cs    3-dog.csproj    3-main.cs
Titania792@ubuntu:~/0x05-csharp-structs_enums\3-dog$ dotnet run
Dog Name: Poppy
Age: 0.7
Owner: Kris
Rating: Excellent
Titania792@ubuntu:~/0x05-csharp-structs_enums\3-dog$

```

-   Directory:  [`3-dog/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x05-csharp-structs_enums/3-dog)
-   File:  [`3-dog.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x05-csharp-structs_enums/3-dog/3-dog.cs)