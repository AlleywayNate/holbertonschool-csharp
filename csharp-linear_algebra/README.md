# 0x09. C# - Linear Algebra
## Background Context

This project is an introduction to linear algebra and its concepts. Linear algebra is essential to computer graphics and will give you a better understanding of what’s going on under the hood of game and graphics engines.

## Tasks
### 0. Pythagoras

Calculate the value of the following and write your answer in a text file:
Given the triangle  `ABC`  where  `AB`  =  `64`  and  `BC`  =  `121`, what is the length of  `AC`?

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/428/0-pythagoras.png)

-   File:  [`0-pythagoras`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/0-pythagoras)

### 1. Magnitude #0 - 2D

Calculate the value of the following and write your answer in a text file:
What is the length of vector  **v**, assuming its origin is  `0`,  `0`?
**v**  =  `(3, 9)`

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/428/1-magnitude_2D.png)

-   File:  [`1-magnitude_2D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/1-magnitude_2D)

### 2. Magnitude #1 - 3D

Calculate the value of the following and write your answer in a text file:
What is the length of  **v**, assuming its origin is  `0`,  `0`,  `0`?
**v**  =  `(7, -3, -9)`

-   File:  [`2-magnitude_3D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/2-magnitude_3D)

### 3. Magnitude #2

Create a method that calculates and returns the length of a given vector.

-   Class:  `VectorMath`
-   Prototype:  `public static double Magnitude(double[] vector)`
-   The vector can be 2D or 3D
-   If the vector is not a 2D or 3D vector, return  `-1`
-   The return value should be rounded to the nearest hundredth
-   File:  [`3-magnitude/3-magnitude.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/3-magnitude/3-magnitude.cs)

### 4. Vector addition #0 - 2D

Calculate the value of the following and write your answer in a text file:
What is the sum of the 2D vectors  **v**  and  **u**?
**v**  =  `(8, -11)`
**u**  =  `(-4, 9)`

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/428/4-vector_addition_2D.png)

-   File:  `4-vector_addition_2D`]()

### 5. Vector addition #1 - 3D

Calculate the value of the following and write your answer in a text file:
What is the sum of the 3D vectors  **v**  and  **u**?
**v**  =  `(14, -2, 0)`
**u**  =  `(-3, 23, 50)`
-   File:  [`5-vector_addition_3D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/5-vector_addition_3D)

### 6. Vector addition #2

Create a method that adds two vectors and returns the resulting vector.
-   Class:  `VectorMath`
-   Prototype:  `public static double[] Add(double[] vector1, double[] vector2)`
-   The vectors can be 2D or 3D
-   If any vector is not a 2D or 3D vector, or if the vectors are not of the same size, return a vector containing  `-1`
-   File:  [`6-vector_addition/6-vector_addition.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/6-vector_addition/6-vector_addition.cs)

### 7. Vector-scalar multiplication #0 - 2D

Calculate the value of the following and write your answer in a text file:
What is the result of multiplying the 2D vector  **v**  and scalar  _x_?
**v**  =  `(98, 972)`
_x_  =  `0.5`

-   File:  [`7-vector_scalar_mul_2D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/7-vector_scalar_mul_2D)

### 8. Vector-scalar multiplication #1 - 3D

Calculate the value of the following and write your answer in a text file:
What is the result of multiplying the 3D vector  **v**  and scalar  _x_?
**v**  =  `(0, -16, 31)`

_x_  =  `4`

-   File:  [`8-vector_scalar_mul_3D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/8-vector_scalar_mul_3D)

### 9. Vector-scalar multiplication #2

Create a method that multiplies a vector and a scalar and returns the resulting vector.

-   Class:  `VectorMath`
-   Prototype:  `public static double[] Multiply(double[] vector, double scalar)`
-   The vectors can be 2D or 3D
-   If any vector is not a 2D or 3D vector, return a vector containing  `-1`
-   File:  [`9-vector_scalar_mul/9-vector_scalar_mul.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/9-vector_scalar_mul/9-vector_scalar_mul.cs)

### 10. Dot product #0 - 2D

Calculate the value of the following and write your answer in a text file:
What is the dot product of  **v**  and  **u**?
**v**  =  `(1, 3)`
**u**  =  `(-2, 5)`

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/428/10-dot_product_2D.png)

-   File:  [`10-dot_product_2D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/10-dot_product_2D)


### 11. Dot product #1 - 3D

Calculate the value of the following and write your answer in a text file:
What is the dot product of  **v**  and  **u**?
**v**  =  `(-4, 0, 10)`
**u**  =  `(3, 7, -9)`

-   File:  [`11-dot_product_3D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/11-dot_product_3D)

### 12. Dot product #2

Create a method that calculates dot product of either two 2D or two 3D vectors.

-   Class:  `VectorMath`
-   Prototype:  `public static double DotProduct(double[] vector1, double[] vector2)`
-   The vectors can be either both 2D or both 3D
-   If any vector is not a 2D or 3D vector, or both vectors are not the same size, return  `-1`
-   File:  [`12-dot_product/12-dot_product.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/12-dot_product/12-dot_product.cs)

### 13. Matrix addition #0

Calculate the value of the following and write your answer in a text file:
What is the result of adding the two matrices  **M**  and  **N**?
**M**  =
```
(14, -3, 0)
(-11, -5, 3)
(2, -9, 13)
```
**N**  =
```
(6, 16, 21)
(5, 2, 0)
(1, 3, 7)
```
-   File:  [`13-matrix_addition`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/13-matrix_addition)

### 14. Matrix addition #1

Create a method that adds two matrices and returns the resulting matrix.

-   Class:  `MatrixMath`
-   Prototype:  `public static double[,] Add(double[,] matrix1, double[,] matrix2)`
-   The matrices can be either both 2D or both 3D
    -   2D ex.:  `double[,] matrix = { { 1, 2 }, { 3, 4 } };`
    -   3D ex.:  `double[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };`
-   If any matrix is not a 2D or 3D matrix, or both matrices are not the same size, return a matrix containing  `-1`
-   File:  [`14-matrix_addition/14-matrix_addition.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/14-matrix_addition/14-matrix_addition.cs)

### 15. Matrix-scalar multiplication #0

Calculate the value of the following and write your answer in a text file:
What is the result of multiplying the matrix  **M**  and scalar  _x_?
**M**  =
```
(-13, 10, 8)
(2, 0, 14)
(-4, -5, 2)
```
_x_  =  `4`
-   File:  [`15-matrix_scalar_mul`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/15-matrix_scalar_mul)

### 16. Matrix-scalar multiplication #1

Create a method that multiplies a matrix and a scalar and returns the resulting matrix.

-   Class:  `MatrixMath`
-   Prototype:  `public static double[,] MultiplyScalar(double[,] matrix, double scalar)`
-   The matrix can be either 2D or 3D
-   If the matrix is not a 2D or 3D matrix, return a matrix containing  `-1`
-   File:  [`16-matrix_scalar_mul/16-matrix_scalar_mul.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/16-matrix_scalar_mul/16-matrix_scalar_mul.cs)

### 17. Matrix-matrix multiplication #0

Calculate the value of the following and write your answer in a text file:
What is the result of multiplying the two matrices  **M**  and  **N**?
**M**  =
```
(2, 3)
(-1, 0)
```
**N**  =
```
(1, 7)
(-8, -2)
```
-   File:  [`17-matrix_matrix_mul`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/17-matrix_matrix_mul)

### 18. Matrix-matrix multiplication #1

Create a method that multiplies two matrices and returns the resulting matrix.
-   Class:  `MatrixMath`
-   Prototype:  `public static double[,] Multiply(double[,] matrix1, double[,] matrix2)`
-   The matrices will not necessarily be square or the same dimensions
-   If the matrices cannot be multiplied, return a matrix containing  `-1`
-   File:  [`18-matrix_matrix_mul/18-matrix_matrix_mul.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/18-matrix_matrix_mul/18-matrix_matrix_mul.cs)

### 19. Matrix rotation #0

Calculate the value of the following and write your answer in a text file:
Rotate the matrix  **M**  by angle  _θ_  (in radians). What is the resulting matrix?
**M**  =

```
(1, 2)
(3, 4)

```
_θ_  =  `-1.57`
-   File:  [`19-matrix_rotate_2D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/19-matrix_rotate_2D)

### 20. Matrix rotation #1

Create a method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
**NOTE:**  “Rotation” in this context means to apply rotation to the  **value**  of each element in the matrix, not changing the positions of the values in the matrix.

-   Class:  `MatrixMath`
-   Prototype:  `public static double[,] Rotate2D(double[,] matrix, double angle)`
-   If the matrix is of an invalid size, return a matrix containing  `-1`
-   File:  [`20-matrix_rotate_2D/20-matrix_rotate_2D.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/20-matrix_rotate_2D/20-matrix_rotate_2D.cs)

### 21. Matrix shear #0

Calculate the value of the following and write your answer in a text file:
Shear the matrix  **M**  by the shear factor  _s_  in the  `X`  direction. What is the resulting matrix?
**M**  =
```
(1, 2)
(3, 4)

```
_s_  =  `2`
-   File:  [`23-matrix_shear_2D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/23-matrix_shear_2D)

### 22. Matrix shear #1

Create a method that shears a square 2D matrix by a given shear factor and returns the resulting matrix.

-   Class:  `MatrixMath`
-   Prototype:  `public static double[,] Shear2D(double[,] matrix, char direction, double factor)`
-   The shear factor can be in either the X or Y direction but not both
-   If the matrix is of an invalid size, return a matrix containing  `-1`
-   If given an axis that is not  `x`  or  `y`, return a matrix containing  `-1`
-   File:  [`24-matrix_shear_2D/24-matrix_shear_2D.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/24-matrix_shear_2D/24-matrix_shear_2D.cs)

### 23. Transpose matrix

Create a method to transpose a matrix and return the resulting matrix.

-   Class:  `MatrixMath`
-   Prototype:  `public static double[,] Transpose(double[,] matrix)`
-   The matrix can be of any dimension or size
-   If the matrix is empty, return an empty matrix
-   File:  [`25-matrix_transpose/25-matrix_transpose.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/25-matrix_transpose/25-matrix_transpose.cs)

### 24. Determinant #0

Calculate the value of the following and write your answer in a text file:
What is the determinant of matrix  **M**?
**M**  =

```
(2, 2)
(-9, 4)

```

-   File:  [`26-determinant_2D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/26-determinant_2D)

### 25. Determinant #1

Calculate the value of the following and write your answer in a text file:
What is the determinant of matrix  **M**?
**M**  =

```
(-4, 9, 0)
(1, -2, 1)
(3, -4, 2)

```

-   File:  [`27-determinant_3D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/27-determinant_3D)

### 26. Determinant #3
Create a method that calculates the determinant of a matrix.

-   Class:  `MatrixMath`
-   Prototype:  `public static double Determinant(double[,] matrix)`
-   If the matrix is not 2D or 3D, return  `-1`
-   File: [ `28-determinant/28-determinant.cs`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x09-csharp-linear_algebra/28-determinant/28-determinant.cs)

### 27. Cross product #0

mandatory

Calculate the value of the following and write your answer in a text file:
What is the cross product of  **v**  and  **u**?
**v**  =  `(2, -2, 1)`
**u**  =  `(-8, 8, -4)`
-   File:  [`29-cross_product`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/29-cross_product)

### 28. Cross product #1

Create a method that calculates the cross product of two 3D vectors and returns the resulting vector.

-   Class:  `VectorMath`
-   Prototype:  `public static double[] CrossProduct(double[] vector1, double[] vector2)`
-   If either vector is not a 3D vector, return a vector containing  `-1`
-   File:  [`30-cross_product/30-cross_product.cs`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x09-csharp-linear_algebra/30-cross_product/30-cross_product.cs)


### 29. Inverse #0

Calculate the value of the following and write your answer in a text file:
What is the inverse of  **M**?
**M**  =
```
(1, 2)
(3, 4)

```
-   File:  [`31-inverse_2D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/31-inverse_2D)

### 30. Inverse #1

Calculate the value of the following and write your answer in a text file:
What is the inverse of  **M**? Round to the nearest hundredth.
**M**  =

```
(11, 8, 7)
(2, 13, 1)
(4, 0, 17)

```
-   File:  [`32-inverse_3D`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/32-inverse_3D)

### 31. Inverse #2

Create a method that calculates the inverse of a 2D matrix and returns the resulting matrix.

-   Class:  `MatrixMath`
-   Prototype:  `public static double[,] Inverse2D(double[,] matrix)`
-   If the matrix is not a 2D matrix, return  `[-1]`
-   If the matrix is non-invertible, return  `[-1]`
-   File:  [`33-inverse_2D/33-inverse_2D.cs`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x09-csharp-linear_algebra/33-inverse_2D/33-inverse_2D.cs)