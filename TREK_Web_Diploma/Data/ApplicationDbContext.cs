using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Models.factory;
using practice_TrekCompany.Models.production;
using practice_TrekCompany.Models.spares.sparesEquipment;
using practice_TrekCompany.Models.spares.sparesFrameset;
using practice_TrekCompany.Models.spares.sparesGroopset;
using practice_TrekCompany.Models.spares.sparesTransmition;
using practice_TrekCompany.Models.spares.sparesWheelset;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        ///factory
        public DbSet<Factory> FactoryDB{ get; set; }
        public DbSet<JobTitle> JobTitleDB { get; set; }
        public DbSet<Staff> StaffDB { get; set; }
        
        ///production
        public DbSet<Bike> BikeDB { get; set; }
        public DbSet<Equipment> EquipmentDB { get; set; }
        public DbSet<Frameset> FramesetDB { get; set; }
        public DbSet<Groopset> GroopsetDB { get; set; }
        public DbSet<Wheelset> WheelsetDB { get; set; }

        ///sparesEquipment
        public DbSet<Brake> BrakeDB { get; set; }
        public DbSet<Grips> GripsDB { get; set; }
        public DbSet<Handlebar> HandlebarDB { get; set; }
        public DbSet<Saddle> SaddleDB { get; set; }
        public DbSet<SeatPost> SeatPostDB { get; set; }
        public DbSet<Steering> SteeringDB { get; set; }
        public DbSet<Stem> StemDB { get; set; }

        ///sparesFrameset
        public DbSet<Fork> ForkDB { get; set; }
        public DbSet<Frame> FrameDB { get; set; }

        ///sparesGroopset
        public DbSet<Carriage> CarriageDB { get; set; }
        public DbSet<Pedals> PedalsDB { get; set; }
        public DbSet<Transmition> TransmitionDB { get; set; }

        ///sparesTransmition
        public DbSet<Cassette> CassetteDB { get; set; }
        public DbSet<FrontGear> FrontGearDB { get; set; }
        public DbSet<Shifter> ShifterDB { get; set; }
        public DbSet<Switch> SwitchDB { get; set; }

        ///sparesWheelset
        public DbSet<Hub> HubDB { get; set; }
        public DbSet<Rim> RimDB { get; set; }
        public DbSet<Tire> TireDB { get; set; }
    }
}
