using BLL.Repository.Entity;

namespace BLL.Service
{
    public class EntityService
    {
        private AppointmentRepo _appointmentService;
        private CityRepo _cityService;
        private HospitalRepo _hospitalService;
        private PatientRepo _patientRepo;
        private PatientHistoryRepo _patientHistoryRepo;
        private PoliclinicRepo _policlinicService;
        private StaffRepo _staffRepo;
        private TitleRepo _titleService;
        private TownRepo _townService;
        private UserRepo _userService;

        public EntityService()
        {
            _appointmentService = new AppointmentRepo();
            _cityService = new CityRepo();
            _hospitalService = new HospitalRepo();
            _patientRepo = new PatientRepo();
            _patientHistoryRepo = new PatientHistoryRepo();
            _policlinicService = new PoliclinicRepo();
            _staffRepo = new StaffRepo();
            _titleService = new TitleRepo();
            _townService = new TownRepo();
            _userService = new UserRepo();
        }

        public AppointmentRepo AppointmentService
        {
            get { return _appointmentService; }
            set { _appointmentService = value; }
        }

        public CityRepo CityService
        {
            get { return _cityService; }
            set { _cityService = value; }
        }

        public HospitalRepo HospitalService
        {
            get { return _hospitalService; }
            set { _hospitalService = value; }
        }

        public PatientRepo PatientService
        {
            get { return _patientRepo; }
            set { _patientRepo = value; }
        }

        public PatientHistoryRepo PatientHistoryService
        {
            get { return _patientHistoryRepo; }
            set { _patientHistoryRepo = value; }
        }

        public PoliclinicRepo PoliclinicService
        {
            get { return _policlinicService; }
            set { _policlinicService = value; }
        }

        public StaffRepo StaffService
        {
            get { return _staffRepo; }
            set { _staffRepo = value; }
        }

        public TitleRepo TitleService
        {
            get { return _titleService; }
            set { _titleService = value; }
        }

        public TownRepo TownService
        {
            get { return _townService; }
            set { _townService = value; }
        }

        public UserRepo UserService
        {
            get { return _userService; }
            set { _userService = value; }
        }
    }
}
