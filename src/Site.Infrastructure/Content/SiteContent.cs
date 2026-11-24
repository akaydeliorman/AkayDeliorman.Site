using Site.Core.Content;
using static Site.Core.Content.LocalizedText;

namespace Site.Infrastructure.Content;

public static class SiteContent
{
    public static readonly IReadOnlyList<ContactLink> ContactLinks =
    [
        new ContactLink(LocalizedText.Same("LinkedIn"), "https://www.linkedin.com/in/akaydeliorman"),
        new ContactLink(LocalizedText.Same("GitHub"), "https://github.com/akaydeliorman"),
        new ContactLink(new LocalizedText("E-posta", "Email"), "mailto:dlrmn.akay@gmail.com"),
    ];

    public static readonly IReadOnlyList<Education> Educations =
    [
        new Education(
            new LocalizedText("Lisans – Bilgisayar Teknolojisi ve Bilişim Sistemleri", "BSc – Computer Technology and Information Systems"),
            new LocalizedText("Trakya Üniversitesi", "Trakya University"),
            StartYear: 2018, EndYear: 2022, Gpa: "3.06 / 4.00"),
        new Education(
            new LocalizedText("Lisans (İkinci Üniversite, Açıköğretim) – Halkla İlişkiler ve Reklamcılık", "Second Bachelor's Degree (Open Education) – Public Relations and Advertising"),
            new LocalizedText("Anadolu Üniversitesi", "Anadolu University"),
            StartYear: 2019, EndYear: 2024),
    ];

    public static readonly IReadOnlyList<Certificate> Certificates =
    [
        new Certificate(
            new LocalizedText("Backend Yazılım Geliştirme Programı (.NET), 15. Dönem", "Backend Software Development Programme (.NET), Cohort 15"),
            LocalizedText.Same("Acunmedya Akademi"),
            Year: 2026,
            InProgress: true,
            Details: new LocalizedText(
                "C#, OOP, LINQ, async/await, SQL, ADO.NET, Entity Framework Core, ASP.NET Core Web API, OpenAPI / Scalar, Docker, ekip projesi",
                "C#, OOP, LINQ, async/await, SQL, ADO.NET, Entity Framework Core, ASP.NET Core Web API, OpenAPI / Scalar, Docker, team project")),
        new Certificate(
            LocalizedText.Same("Java Spring Bootcamp"),
            LocalizedText.Same("Akbank"),
            Year: 2023),
    ];

    public static readonly IReadOnlyList<SkillGroup> SkillGroups =
    [
        new SkillGroup(Same("Backend (.NET)"),
        [
            Same("C#"), Same(".NET 10"), Same("ASP.NET Core Web API"), Same("Minimal API"),
            Same("Entity Framework Core"), Same("ADO.NET"), Same("LINQ"), Same("async/await"),
            Same("FluentValidation"), Same("Mapster"),
        ]),
        new SkillGroup(new LocalizedText("Mimari ve Kalıplar", "Architecture and Patterns"),
        [
            Same("Clean Architecture"),
            new LocalizedText("Katmanlı Mimari", "Layered Architecture"),
            new LocalizedText("RESTful API Tasarımı", "RESTful API Design"),
            Same("Dependency Injection"), Same("Repository Pattern"), Same("Result Pattern"),
            Same("DTO"), Same("OOP"),
        ]),
        new SkillGroup(new LocalizedText("API Dokümantasyonu", "API Documentation"),
        [
            Same("OpenAPI"), Same("Swagger"), Same("Scalar"),
        ]),
        new SkillGroup(new LocalizedText("Veritabanı", "Databases"),
        [
            Same("SQL Server"), Same("T-SQL"), Same("PostgreSQL"), Same("Firebase Realtime Database"),
        ]),
        new SkillGroup(new LocalizedText("Güvenlik", "Security"),
        [
            new LocalizedText("JWT Kimlik Doğrulama", "JWT Authentication"),
            new LocalizedText("Sahiplik / Üyelik Tabanlı Yetkilendirme", "Ownership / Membership-Based Authorisation"),
            new LocalizedText("BCrypt Şifre Hashleme", "BCrypt Password Hashing"),
            new LocalizedText("Parametreli Sorgular", "Parameterised Queries"),
            Same("User Secrets"),
        ]),
        new SkillGroup(new LocalizedText("Diğer Diller ve Alanlar", "Other Languages and Areas"),
        [
            Same("Java (Spring Boot)"), Same("Kotlin"), Same("Python (PyTorch, OpenCV)"), Same("C/C++"),
            Same("MATLAB"), Same("Android"),
            new LocalizedText("Görüntü İşleme", "Image Processing"),
            new LocalizedText("Derin Öğrenme", "Deep Learning"),
            Same("IoT"),
        ]),
        new SkillGroup(new LocalizedText("Araçlar", "Tools"),
        [
            Same("Git"), Same("GitHub"), Same("Docker"), Same("Postman"), Same("VS Code"), Same("Android Studio"),
        ]),
        new SkillGroup(new LocalizedText("Öğrenme Sürecinde", "Currently Learning"),
        [
            Same("xUnit"), Same("GitHub Actions (CI/CD)"), Same("JavaScript"), Same("React"),
        ]),
    ];

    public static readonly Profile Profile = new Profile(
        FullName: "Akay Deliorman",
        Headline: new LocalizedText(
            "Backend Developer (.NET) | Yazılım Geliştirici",
            "Backend Developer (.NET) | Software Developer"),
        Summary: new LocalizedText(
            "C#, .NET 10 ve ASP.NET Core Web API ile backend geliştirmeye odaklanan, 2 yılı aşkın Ar-Ge deneyimine sahip yazılım geliştiriciyim. Acunmedya Akademi Backend programında 5+ kişilik bir ekiple Clean Architecture üzerine kurulu bir proje yönetim REST API'si geliştirdim; JWT kimlik doğrulama, Entity Framework Core, FluentValidation ve Swagger / OpenAPI ile frontend ekibine net bir API sözleşmesi sundum. Öncesinde Hometech Ar-Ge Merkezi'nde Ulusal Dolaşım Android uygulaması ve yapay zekâ destekli göz hastalıkları tespit sistemi projelerinde görev aldım.",
            "Software developer focused on backend development with C#, .NET 10 and ASP.NET Core Web API, with over two years of R&D experience. In the Acunmedya Akademi Backend programme, I built a project management REST API on Clean Architecture in a team of 5+ developers, delivering a clear API contract to the frontend team with JWT authentication, Entity Framework Core, FluentValidation and Swagger / OpenAPI. Previously, at Hometech R&D Centre, I worked on a National Roaming Android application and an AI-based eye disease detection system."),
        Location: new LocalizedText("İstanbul, Türkiye", "Istanbul, Türkiye"),
        Citizenship: new LocalizedText(
            "Türkiye ve Bulgaristan vatandaşı (AB vatandaşı – AB ülkelerinde çalışma izni gerektirmez)",
            "Turkish and Bulgarian citizen (EU citizen – no work permit required in the EU)"),
        Languages:
        [
            new LocalizedText("Türkçe: Ana dil", "Turkish: Native"),
            new LocalizedText("İngilizce: B1/B2 (Orta-İleri)", "English: B1/B2 (Upper-Intermediate)"),
            new LocalizedText("Almanca: A2 (Temel)", "German: A2 (Elementary)"),
        ]);

    public static readonly IReadOnlyList<Experience> Experiences =
    [
        new Experience(
            new LocalizedText("Yazılım Geliştirici", "Software Developer"),
            new LocalizedText("Hometech Ar-Ge Merkezi", "Hometech R&D Centre"),
            Start: new DateOnly(2024, 6, 1),
            End: new DateOnly(2026, 7, 1),
            Items:
            [
                new ExperienceItem(
                    Title: new LocalizedText("Ulusal Dolaşım", "National Roaming"),
                    Technologies: ["Java", "Android SDK", "TelephonyManager API", "Location Services"],
                    Highlights:
                    [
                        new LocalizedText(
                            "Deprem ve doğal afet anlarında, ana operatör erişilemez olduğunda cihazın mevcut en güçlü şebekeye otomatik geçişini sağlayan Android şebeke yönetim altyapısını kurguladım.",
                            "Designed Android network management infrastructure that automatically switches the device to the strongest available network when the primary operator is unreachable during earthquakes and natural disasters."),
                        new LocalizedText(
                            "Acil durum SMS yayını, dinamik APN listesi alma ve konum tabanlı otomatik kriz bildirim modüllerini geliştirdim; arka plan sinyal taramasında pil tüketimini azaltmak için şebeke izleme yapılarını optimize ettim.",
                            "Developed emergency SMS broadcast, dynamic APN list retrieval and location-based automatic crisis notification modules; optimised network monitoring to reduce battery drain during background signal scanning."),
                    ]),
                new ExperienceItem(
                    Title: new LocalizedText("Yapay Zekâ Destekli Göz Hastalıkları Tespit Sistemi", "AI-Based Eye Disease Detection System"),
                    Technologies: ["Python", "PyTorch", "OpenCV", "MATLAB", "Kotlin", "Java"],
                    Highlights:
                    [
                        new LocalizedText(
                            "Akıllı telefona takılan optik aparatla Damar Kıvrımlılığı, Glokom, Santral Seröz Retinopati ve Diyabetik Retinopati tespiti yapan uçtan uca görüntü işleme ve derin öğrenme pipeline'ının geliştirilmesinde görev aldım (Kaggle ve RFMiD veri setleri).",
                            "Contributed to an end-to-end image processing and deep learning pipeline detecting vessel tortuosity, glaucoma, central serous retinopathy and diabetic retinopathy via a smartphone optical attachment (Kaggle and RFMiD datasets)."),
                        new LocalizedText(
                            "Klasik görüntü işleme tekniklerini (yeşil kanal, CLAHE, Gaussian, Otsu eşikleme) PyTorch modelleriyle birleştirerek erken teşhiste %83 doğruluk oranına ulaştık; glokom için Cup-to-Disc Ratio (CDR) modülünü geliştirdik.",
                            "Combined classical image processing (green channel, CLAHE, Gaussian blur, Otsu thresholding) with PyTorch models to reach 83% accuracy in early detection; developed a cup-to-disc ratio (CDR) module for glaucoma."),
                        new LocalizedText(
                            "Optik aparat, bulut servisleri ve cihaz üzerinde çıkarım (on-device inference) modüllerini birleştiren native Android uygulamasını geliştirdik.",
                            "Developed a native Android app integrating the optical attachment, cloud services and on-device inference modules."),
                    ]),
            ]),
        new Experience(
            new LocalizedText("Front-end Geliştirici Stajyeri", "Front-end Developer Intern"),
            new LocalizedText("Vision Lab Dijital Pazarlama", "Vision Lab Digital Marketing"),
            Start: new DateOnly(2021, 8, 1),
            End: new DateOnly(2021, 9, 1),
            Items:
            [
                new ExperienceItem(
                    Title: null,
                    Technologies: [],
                    Highlights:
                    [
                        new LocalizedText(
                            "Müşteri web sitelerinin ön yüz geliştirme ve kullanıcı arayüzü düzenleme süreçlerinde görev aldım; SEO ve performans reklamcılığı metrikleri üzerine teknik araştırmalar yürüttüm.",
                            "Worked on front-end development and UI improvements for client websites; researched SEO and performance advertising metrics."),
                    ]),
            ]),
    ];

    public static readonly IReadOnlyList<Project> Projects =
    [
        new Project(
            Slug: "taskflow",
            Title: new LocalizedText("TaskFlow – Asana Klonu Proje Yönetimi REST API'si", "TaskFlow – Project Management REST API (Asana Clone)"),
            Context: new LocalizedText("Ekip Projesi, Acunmedya Akademi", "Team Project, Acunmedya Akademi"),
            Year: 2026,
            Summary: new LocalizedText(
                "5+ kişilik bir backend ekibiyle Clean Architecture üzerine kurduğumuz, JWT ile korunan proje ve görev yönetimi REST API'si.",
                "A project and task management REST API built on Clean Architecture with a backend team of 5+, secured with JWT."),
            Technologies: ["C#", ".NET 10", "ASP.NET Core Web API", "Entity Framework Core", "SQL Server", "Docker", "JWT", "BCrypt", "FluentValidation", "Mapster", "Swagger / OpenAPI", "Clean Architecture"],
            Highlights:
            [
                new LocalizedText(
                    "5+ kişilik backend ekibinde, Clean Architecture (Domain / Application / Infrastructure / API) üzerine kurulu REST API'nin proje, görev ve kimlik doğrulama modüllerini geliştirdim; GitHub Issues, Conventional Commits, feature branch, pull request ve kod incelemesiyle çalıştım.",
                    "In a backend team of 5+ developers, built the project, task and authentication modules of a REST API on Clean Architecture (Domain / Application / Infrastructure / API); worked with GitHub Issues, Conventional Commits, feature branches, pull requests and code reviews."),
                new LocalizedText(
                    "Tüm API için ortak bir ApiResponse zarfı ve base controller tasarladım; middleware kaynaklı 500 hatalarını ve otomatik 400 cevaplarını aynı formata alarak frontend ekibine tek tip bir API sözleşmesi sağladım.",
                    "Designed a shared ApiResponse envelope and base controller for the whole API, bringing middleware 500 errors and automatic 400 responses into the same format so the frontend team could rely on a single contract."),
                new LocalizedText(
                    "JWT token'ından kullanıcıyı okuyan erişim kontrolü kurdum: projeye üye olmayan 404, sahip olmayan 403 alır; bir görevin başka projenin kolonuna taşınmasını engelleyerek IDOR açığını kapattım.",
                    "Implemented access control that reads the user from the JWT: non-members get 404 and non-owners get 403; closed an IDOR vulnerability by preventing tasks from being moved into another project's columns."),
                new LocalizedText(
                    "Hata durumlarını exception yerine Result Pattern (ServiceResult + ErrorType) ile modelledim; şifre değiştirme akışını async/await, BCrypt hashleme ve token'dan alınan kullanıcı kimliğiyle güvenli şekilde kurdum.",
                    "Modelled failures with the Result Pattern (ServiceResult + ErrorType) instead of exceptions; built a secure password change flow with async/await, BCrypt hashing and the user identity taken from the token."),
                new LocalizedText(
                    "Endpoint'leri sahip / üye / yabancı / token'sız kullanıcı senaryolarıyla doğruladım; SQL Server'ı Docker'da çalıştırıp bağlantı bilgilerini ve JWT anahtarını user-secrets ile koddan ayırdım.",
                    "Verified endpoints against owner, member, outsider and unauthenticated scenarios; ran SQL Server in Docker and kept connection strings and the JWT key out of the code with user secrets."),
            ],
            IsFeatured: true),
                    new Project(
            Slug: "gamerental",
            Title: new LocalizedText("GameRental – Oyun Kiralama Web API'si", "GameRental – Game Rental Web API"),
            Context: new LocalizedText("Bireysel Proje", "Personal Project"),
            Year: 2026,
            Summary: new LocalizedText(
                "Konsol uygulamasından katmanlı bir ASP.NET Core Minimal API'ye dönüştürdüğüm, Docker ile paketlenmiş oyun kiralama servisi.",
                "A game rental service I turned from a console app into a layered ASP.NET Core Minimal API, containerised with Docker."),
            Technologies: ["C#", ".NET 10", "ASP.NET Core Minimal API", "Swagger / OpenAPI", "Docker", "Dependency Injection", "OOP"],
            Highlights:
            [
                new LocalizedText(
                    "Konsol tabanlı bir oyun kiralama uygulamasını; iş mantığı ayrı bir sınıf kütüphanesinde (Core) duran ve ASP.NET Core Minimal API ile sunulan katmanlı bir Web API'ye dönüştürdüm.",
                    "Turned a console-based game rental application into a layered Web API, with business logic in a separate class library (Core) exposed through ASP.NET Core Minimal API."),
                new LocalizedText(
                    "Oyun, müşteri, kiralama ve iade işlemleri için RESTful endpoint'ler geliştirdim; endpoint'leri extension method ve MapGroup ile gruplayarak Program.cs'i sade tuttum.",
                    "Built RESTful endpoints for games, customers, rentals and returns; organised endpoints into groups with extension methods and MapGroup to keep Program.cs clean."),
                new LocalizedText(
                    "Stok, yaş sınırı ve iade kurallarını Result Pattern ile modelledim; hata türlerini tek bir yardımcı sınıfta HTTP 400 / 404 / 409 kodlarına çevirdim.",
                    "Modelled stock, age limit and return rules with the Result Pattern, mapping error types to HTTP 400 / 404 / 409 in a single helper class."),
                new LocalizedText(
                    "Kalıtımlı modellerde JSON alan kaybını DTO ve fabrika metotlarla çözdüm; uygulamayı iki aşamalı (multi-stage) Dockerfile ile container'a aldım.",
                    "Solved lost JSON fields in inherited models with DTOs and factory methods; containerised the application with a multi-stage Dockerfile."),
            ],
            IsFeatured: true),
        new Project(
            Slug: "coursehub",
            Title: new LocalizedText("CourseHub – SQL Server ve ADO.NET Veri Katmanı", "CourseHub – SQL Server and ADO.NET Data Layer"),
            Context: Same("Acunmedya Akademi"),
            Year: 2026,
            Summary: new LocalizedText(
                "Kurs, öğrenci ve kayıtları kısıtlarla modelleyen bir SQL Server şeması ve SQL Injection'a karşı güvenli bir ADO.NET veri katmanı.",
                "A SQL Server schema modelling courses, students and enrolments with constraints, plus an ADO.NET data layer safe from SQL injection."),
            Technologies: ["SQL Server", "T-SQL", "ADO.NET", "Microsoft.Data.SqlClient", "C#", "Docker"],
            Highlights:
            [
                new LocalizedText(
                    "Kurs, öğrenci ve kayıt ilişkilerini PK/FK, UNIQUE ve CHECK kısıtlarıyla modelleyen ilişkisel veritabanı şemasını tasarladım; kısıtları test script'leriyle doğruladım.",
                    "Designed a relational database schema modelling courses, students and enrolments with PK/FK, UNIQUE and CHECK constraints; verified the constraints with test scripts."),
                new LocalizedText(
                    "ADO.NET ile parametreli sorgular (SqlParameter) yazarak SQL Injection'ı önledim; bağlantı şifresini koda yazmak yerine ortam değişkeninden okudum.",
                    "Prevented SQL injection by writing parameterised queries (SqlParameter) with ADO.NET; read the connection password from an environment variable instead of hard-coding it."),
                new LocalizedText(
                    "Latin1 collation'da \"MİMARİ\" aramasının sonuç vermemesine yol açan Türkçe İ sorununu tespit edip COLLATE Turkish_CI_AS ile çözdüm; Northwind veritabanında JOIN, GROUP BY / HAVING ve toplama fonksiyonları içeren 40 T-SQL sorgusu yazdım.",
                    "Diagnosed a Turkish dotted-İ issue that made a search for \"MİMARİ\" return no results under Latin1 collation and fixed it with COLLATE Turkish_CI_AS; wrote 40 T-SQL queries on the Northwind database using JOIN, GROUP BY / HAVING and aggregate functions."),
            ],
            IsFeatured: true),
        new Project(
            Slug: "weather-forecast",
            Title: new LocalizedText("RESTful Hava Durumu Tahmin Servisi", "RESTful Weather Forecast Service"),
            Context: new LocalizedText("Akbank Java Spring Bootcamp Bitirme Projesi", "Akbank Java Spring Bootcamp Final Project"),
            Year: 2023,
            Summary: new LocalizedText(
                "OpenWeatherMap verisini JWT korumalı endpoint'lerle sunan, PostgreSQL önbellekli Spring Boot servisi.",
                "A Spring Boot service serving OpenWeatherMap forecasts through JWT-protected endpoints, with a PostgreSQL cache."),
            Technologies: ["Java", "Spring Boot", "PostgreSQL", "JWT", "OpenWeatherMap API", "Swagger / OpenAPI", "JUnit"],
            Highlights:
            [
                new LocalizedText(
                    "OpenWeatherMap entegrasyonuyla 5 günlük hava durumu verisi sunan, JWT tabanlı kimlik doğrulama ve favori şehir takibi içeren Spring Boot RESTful servisi geliştirdim; harici API gecikmelerini azaltmak için PostgreSQL ile önbellek kurdum, JUnit testleri ve Swagger dokümantasyonu ekledim.",
                    "Built a Spring Boot RESTful service providing five-day forecasts via OpenWeatherMap, with JWT-based authentication and favourite-city tracking; added a PostgreSQL cache to reduce external API latency, along with JUnit tests and Swagger documentation."),
            ],
            IsFeatured: false),
        new Project(
            Slug: "smart-home",
            Title: new LocalizedText("IoT Tabanlı Akıllı Ev Kontrol Sistemi", "IoT-Based Smart Home Control System"),
            Context: new LocalizedText("Lisans Bitirme Projesi (Bireysel)", "Undergraduate Thesis (Individual)"),
            Year: 2022,
            Summary: new LocalizedText(
                "Sesli komut destekli bir Android uygulamasıyla yönetilen, Firebase ile anlık senkronize olan IoT akıllı ev prototipi.",
                "An IoT smart home prototype controlled by a voice-enabled Android app and synchronised in real time via Firebase."),
            Technologies: ["Java", "Android Studio", "Arduino (C)", "Firebase Realtime Database", "IoT"],
            Highlights:
            [
                new LocalizedText(
                    "Aydınlatma, gaz tespiti, otomatik kapı kilidi ve alarm modüllerini içeren IoT akıllı ev prototipi ile sesli komut destekli native Android uygulaması geliştirdim; Firebase ile anlık, çift yönlü veri senkronizasyonu sağladım.",
                    "Developed a smart home prototype with lighting, gas detection, automatic door lock and alarm modules, plus a native Android app with voice commands; used Firebase for real-time two-way data synchronisation."),
            ],
            IsFeatured: false),
    ];
}