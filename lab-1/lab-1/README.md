# ����������� ������: ��������� ������� �� ������������

## ���������� �������� �������������

### 1. DRY (Don't Repeat Yourself)
**����:** ��������� ���������� ���� ����� ������������ ���������� (`IProduct`, `IMoney`), ������� �������� ����� (`Reporting`, `Warehouse`) �� ����������� ��� �����.

���: [IMoney.cs](Interfaces/IMoney.cs), [IProduct.cs](Interfaces/IProduct.cs)

---

### 2. KISS (Keep It Simple, Stupid)
**����:** ����� ���� �� ���������, ������ �������������. ���������, `Cart` ����� ������ � �������, � `Reporting` ���� ������ ����.

���: [Cart.cs](Models/Cart.cs), [Reporting.cs](Services/Reporting.cs)

---

### 3. SOLID (5 ��������)
- **S** (Single Responsibility) � ����� ���� ������ ����� ���� ������.  
���: [Warehouse.cs](Services/Warehouse.cs) (��������� ������)  
- **O** (Open/Closed) � ������ ���� ������ (����., `GBP`) ����� ����� ����������� `IMoney`, �� ������� ���.  
���: [USD.cs](Models/USD.cs), [EUR.cs](Models/EUR.cs)  
- **L** (Liskov Substitution) � `USD`, `EUR` ������ �������������� ����� `IMoney`.  
���: [IMoney.cs](Interfaces/IMoney.cs)  
- **I** (Interface Segregation) � `IMoney`, `IProduct`, `IWarehouse` ����� ���� ��������.  
���: [ICart.cs](Interfaces/ICart.cs)  
- **D** (Dependency Inversion) � ��������� ����������� ����� ���������� (`IWarehouse`, `IProduct`).  
���: [Warehouse.cs](Services/Warehouse.cs)

---

### 4. YAGNI (You Ain't Gonna Need It)
**����:** � ��� ���� ������� �����������, ����� ���������: �����, ������, ������, �����, �������.

���: ���� �����

---

### 5. Composition Over Inheritance
**����:** ������ ����������� `Product` �� `Money`, �� ������������� ���������� (`Product` ������ `IMoney`).

���: [Product.cs](Models/Product.cs)

---

### 6. Program to Interfaces, Not Implementations
**����:** ��� �����䳺 ����� `IMoney`, `IProduct`, `IWarehouse` ������ ���������� �����.

���: [IMoney.cs](Interfaces/IMoney.cs), [IProduct.cs](Interfaces/IProduct.cs)

---

### 7. Fail Fast
**����:** �������� � ����������� �� ������� (������� �� ��������� ��������).

���: [Cart.cs](Models/Cart.cs), [Warehouse.cs](Services/Warehouse.cs)