# Лабораторна робота: Управління складом та замовленнями

## Дотримання принципів програмування

### 1. DRY (Don't Repeat Yourself)
**Опис:** Уникнення дублювання коду через використання інтерфейсів (`IProduct`, `IMoney`), окремих сервісних класів (`Reporting`, `Warehouse`) та наслідування для валют.

Код: [IMoney.cs](Interfaces/IMoney.cs), [IProduct.cs](Interfaces/IProduct.cs)

---

### 2. KISS (Keep It Simple, Stupid)
**Опис:** Кожен клас має конкретну, просту відповідальність. Наприклад, `Cart` тільки працює з кошиком, а `Reporting` лише генерує звіти.

Код: [Cart.cs](Models/Cart.cs), [Reporting.cs](Services/Reporting.cs)

---

### 3. SOLID (5 принципів)
- **S** (Single Responsibility) – кожен клас виконує тільки одну задачу.  
Код: [Warehouse.cs](Services/Warehouse.cs) (зберігання товарів)  
- **O** (Open/Closed) – додати нову валюту (напр., `GBP`) можна через наслідування `IMoney`, не змінюючи код.  
Код: [USD.cs](Models/USD.cs), [EUR.cs](Models/EUR.cs)  
- **L** (Liskov Substitution) – `USD`, `EUR` можуть взаємозамінятися через `IMoney`.  
Код: [IMoney.cs](Interfaces/IMoney.cs)  
- **I** (Interface Segregation) – `IMoney`, `IProduct`, `IWarehouse` мають чіткі обов’язки.  
Код: [ICart.cs](Interfaces/ICart.cs)  
- **D** (Dependency Inversion) – залежності передаються через інтерфейси (`IWarehouse`, `IProduct`).  
Код: [Warehouse.cs](Services/Warehouse.cs)

---

### 4. YAGNI (You Ain't Gonna Need It)
**Опис:** В коді немає зайвого функціоналу, тільки необхідне: склад, товари, валюта, кошик, звітність.

Код: Весь проєкт

---

### 5. Composition Over Inheritance
**Опис:** Замість наслідування `Product` від `Money`, ми використовуємо композицію (`Product` містить `IMoney`).

Код: [Product.cs](Models/Product.cs)

---

### 6. Program to Interfaces, Not Implementations
**Опис:** Код взаємодіє через `IMoney`, `IProduct`, `IWarehouse` замість конкретних класів.

Код: [IMoney.cs](Interfaces/IMoney.cs), [IProduct.cs](Interfaces/IProduct.cs)

---

### 7. Fail Fast
**Опис:** Перевірки в конструкторі та методах (винятки на некоректні операції).

Код: [Cart.cs](Models/Cart.cs), [Warehouse.cs](Services/Warehouse.cs)