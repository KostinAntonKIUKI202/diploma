using Microsoft.AspNetCore.Identity;
using TREK_Web_Diploma.Data.Enum;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Models.factory;
using TREK_Web_Diploma.Models.production;
using TREK_Web_Diploma.Models.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.BikeDB.Any())
                {
                    context.BikeDB.Add(new Bike()
                    { 
                        
                            BikeName = "Trek Marlin 4 Gen 2",
                            BikeImage = "https://ukrbike.com.ua/assets/cache/images/2022/marlin4_22_29759_a_portrait-1000x-e54.jpg",
                            BikeDescription = "Класичний гірський велосипед Trek Marlin 4 із оновленою рамою. Троси приховані всередині рами, зручне та практичне рішення, яке притаманне більш дорогим моделям. Добре знайома серія жіночих велосипедів Marlin WSD припиняє своє існування. Моделі не ділитимуться на чоловічі та жіночі, натомість кількість кольорових рішень для кожної з версій збільшилась. Рами у ростовках XS і S мають колеса 27.5 дюймів і занижену верхню трубу, що значно полегшує експлуатацію велосипеду райдерами із зростом до 165 см. Всі інші ростовки мають пряму верхню трубу і 29-дюймові колеса. Передбачені кріплення для встановлення багажника та підніжки.",
                            BikePrice = 25500,
                            BikeWeight = 13.98,
                            Frameset = new Frameset()
                            {
                                Fork = new Fork()
                                {
                                    ForkName = "SR Suntour XCE 28",
                                    ForkDescription = "Пружинна, регулювання навантаження, хід 100 мм ( у розмірі XS - хід 80 мм)",
                                    ForkQuantity = 354
                                },
                                Frame = new Frame()
                                {
                                    FrameName = "Alpha Silver Aluminium",
                                    FrameDescription = "Внутрішнє проведення тросів перемикачів, гідролінії заднього гальма та дроппер-посту, інтегроване кріплення підніжки та багажника",
                                    FrameQuantity = 78
                                }
                            },
                            Wheelset = new Wheelset()
                            {
                                Hub = new Hub()
                                {
                                    HubName = "Formula DC20 / Formula DC31",
                                    HubDescription = "Втулки під ексцентрик, насипна вальнииця",
                                    HubQuantity = 453
                                },
                                Rim = new Rim()
                                {
                                    RimName = "Bontrager Connection",
                                    RimDescription = "32 отв, подвійні",
                                    RimQuantity = 78
                                },
                                Tire = new Tire()
                                {
                                    TireName = "Bontrager XR2 Comp",
                                    TireDescription = "27.5\"х2.20\", у розмірах M, M/L, L, XL, XXL передня 29\"x2.20˝, задня 29\"х2.00\"",
                                    TireQuantity = 561
                                }
                            },
                            Groopset = new Groopset()
                            {
                                Carriage = new Carriage()
                                {
                                    CarriageName = "Картриджна, 73 мм",
                                    CarriageQuantity = 432
                                },
                                Pedals = new Pedals()
                                {
                                    PedalsName = "VP-536, платформи, нейлон",
                                    PedalsQuantity = 651
                                },
                                Transmition = new Transmition()
                                {
                                    Cassette = new Cassette()
                                    {
                                        CassetteName = "Shimano TZ500, 14-28, 7 шв.",
                                        CassetteQuantity = 561
                                    },
                                    Switch = new Switch()
                                    {
                                        SwitchName = "перед./зад. Shimano Tourney TY300",
                                        SwitchQuantity = 351
                                    },
                                    Shifter = new Shifter()
                                    {
                                        ShifterName = "Shimano Altus EF500, 7 шв.",
                                        ShifterQuantity = 321
                                    },
                                    FrontGear = new FrontGear()
                                    {
                                        FrontGearName = "",
                                        FrontGearQuantity = 456
                                    }
                                }
                            },
                            Equipment = new Equipment()
                            {
                                Brake = new Brake()
                                {
                                    BrakeName = "Tektro MD-280 дискові, механічні",
                                    BrakeQuantity = 214
                                },
                                Saddle = new Saddle()
                                {
                                    SaddleName = "Bontrager Arvada, рейки - сталеві",
                                    SaddleQuantity = 347
                                },
                                SeatPost = new SeatPost()
                                {
                                    SeatPostName = "Bontrager, алюм, 31.6 мм, офсет 12 мм",
                                    SeatPostQuantity = 684
                                },
                                Stem = new Stem()
                                {
                                    StemName = "Bontrager, алюм, 31.8 мм, підйом 7 градусів, сумісний з Blendr",
                                    StemQuantity = 285
                                },
                                Handlebar = new Handlebar()
                                {
                                    HandlbarName = "Bontrager, алюм, 31.8 мм, підйом 5 мм, ширина 720 мм (на XS та S: ширина 690 мм)",
                                    HandlebarQuantity = 648
                                },
                                Grips = new Grips()
                                {
                                    GripsName = "Bontrager XR Endurance Comp",
                                    GripsQuantity = 954
                                },
                                Steering = new Steering()
                                {
                                    SteeringName = "1-1/8˝ напівінтегрована",
                                    SteeringQuantity = 349
                                }
                            },
                            TypeOfBike = TypeOfBike.Хардтейл
                    });
                }
                if (!context.StaffDB.Any())
                {
                    context.StaffDB.Add(new Staff()
                    {
                        FirstName = "Олег",
                        SecondName = "Степанів",
                        Factory = new Factory()
                        {
                            City = "Харків",
                            Street = "Сумська",
                            ZipCode = "61000"
                        },
                        JobTitle = new JobTitle()
                        {
                            JobTitleName = "Продавець"
                        }
                    });
                }
            }
        }
    }
}
