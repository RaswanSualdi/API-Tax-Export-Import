

---

# API Tax Export - Import

The application is a demo API for tax export-import.

## Prasyarat

Pastikan Anda telah menginstal prasyarat berikut sebelum menjalankan aplikasi ini:

- [.NET SDK](https://dotnet.microsoft.com/download) versi 8.0
- IDE such as Rider or Visual Studio
- PostgreSQL

## Instalasi

1. Klon repositori ini:

    ```bash
    git clone https://github.com/RaswanSualdi/API-Tax-Export-Import.git
    ```

2. Pindah ke direktori proyek:

    ```bash
    cd API-Tax-Export-Import/WebApplication2
    ```

3. Jalankan aplikasi:

    ```bash
    dotnet run
    ```

4. Buka aplikasi di browser:

   [http://localhost:5259/swagger/index.html](http://localhost:5259/swagger/index.html)

## Penggunaan

- Enpoint untuk menampilkan semua negara dan negara tertentu dengan ur_negara

![Screenshot 1](Screenshot%20from%202023-12-04%2021-32-15.png)


- Endpoint untuk menampilkan pelabuhan berdasarkan kd_negara dan ur_pelabuhan

![Screenshot 2](Screenshot%20from%202023-12-04%2021-37-12.png)

- Enpoint untuk menampilkan barang berdasarkan hs_code

![Screenshot 3](Screenshot%20from%202023-12-04%2021-41-58.png)

- Endpoint untuk menghitung tarif bea masuk 

![Screenshot 4](Screenshot%20from%202023-12-04%2021-46-06.png)
![Screenshot 5](Screenshot%20from%202023-12-04%2021-47-26.png)

## Konfigurasi

Jangan lupa untuk mengubah konfigurasi database anda pada file [appsettings.json](appsettings.json) : 
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "WebApplication2" : "Host=localhost;Port=5432;Database=your_database;Username=your_username;Password=your_password"
  }
}
```

## Informasi Tambahan

Jika Anda ingin mengetahui seeder data (data dummy) yang di migration pada database silahkan buka file ```WebApplication2Context.cs```
pada Folder ```Database```

