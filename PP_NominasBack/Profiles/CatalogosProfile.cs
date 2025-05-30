using AutoMapper;
using PP_NominasBack.Models.Catalogos.Asistencia;
using PP_NominasBack.Dtos.Catalogos.Asistencia;
using PP_NominasBack.Models.Catalogos.Biometria;
using PP_NominasBack.Dtos.Catalogos.Biometria;
using PP_NominasBack.Models.Catalogos.Compensaciones;
using PP_NominasBack.Dtos.Catalogos.Compensaciones;
using PP_NominasBack.Models.Catalogos.Configuracion;
using PP_NominasBack.Dtos.Catalogos.Configuracion;
using PP_NominasBack.Models.Catalogos.Deducciones;
using PP_NominasBack.Dtos.Catalogos.Deducciones;
using PP_NominasBack.Models.Catalogos.Empleados;
using PP_NominasBack.Dtos.Catalogos.Empleados;
using PP_NominasBack.Models.Catalogos.Fiscal;
using PP_NominasBack.Dtos.Catalogos.Fiscal;
using PP_NominasBack.Models.Catalogos.Incidencias;
using PP_NominasBack.Dtos.Catalogos.Incidencias;
using PP_NominasBack.Models.Catalogos.Nomina;
using PP_NominasBack.Dtos.Catalogos.Nomina;
using PP_NominasBack.Models.Catalogos.Organizacion;
using PP_NominasBack.Dtos.Catalogos.Organizacion;
using PP_NominasBack.Models.Catalogos.Prenomina;
using PP_NominasBack.Dtos.Catalogos.Prenomina;
using PP_NominasBack.Models.Catalogos.Prestaciones;
using PP_NominasBack.Dtos.Catalogos.Prestaciones;
using PP_NominasBack.Models.Catalogos.Seguridad;
using PP_NominasBack.Dtos.Catalogos.Seguridad;
using PP_NominasBack.Models.Catalogos.Vacaciones;
using PP_NominasBack.Dtos.Catalogos.Vacaciones;
using PP_NominasBack.Models.Catalogos.Shared;
using PP_NominasBack.Dtos.Catalogos.Shared;
using PP_NominasBack.Models.Catalogos.Organización;
using PP_NominasBack.Dtos.Catalogos.Organización;

namespace PP_NominasBack.Profiles
{
    public class CatalogosProfile : Profile
    {
        public CatalogosProfile()
        {
            // Empleados
            // Empleados
            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
            CreateMap<Persona, PersonaDto>();
            CreateMap<PersonaDto, Persona>();
            CreateMap<Direccion, DireccionDto>().ReverseMap();
            CreateMap<Telefono, TelefonoDto>().ReverseMap();
            CreateMap<AsignacionPlazaEmpleado, AsignacionPlazaEmpleadoDto>();
            CreateMap<AsignacionPlazaEmpleadoDto, AsignacionPlazaEmpleado>();
            CreateMap<HorarioEmpleado, HorarioEmpleadoDto>().ReverseMap();
            CreateMap<UbicacionEmpleado, UbicacionEmpleadoDto>().ReverseMap();
            CreateMap<HistorialUbicacionEmpleado, HistorialUbicacionEmpleadoDto>().ReverseMap();
            CreateMap<RegistroImss, RegistroImssDto>().ReverseMap();
            CreateMap<DatosPagoEmpleado, DatosPagoEmpleadoDto>();
            CreateMap<DatosPagoEmpleadoDto, DatosPagoEmpleado>();
            CreateMap<DocumentoEmpleado, DocumentoEmpleadoDto>().ReverseMap();
            CreateMap<ContactoEmergencia, ContactoEmergenciaDto>().ReverseMap();

            // Shared
            CreateMap<AlertaNotificacion, AlertaNotificacionDto>().ReverseMap();
            CreateMap<Auditable, AuditableDto>().ReverseMap();
            CreateMap<CatalogoEntidades, CatalogoEntidadesDto>().ReverseMap();
            CreateMap<Contacto, ContactoDto>().ReverseMap();

            // Asistencia
            CreateMap<CalendarioLaboral, CalendarioLaboralDto>().ReverseMap();
            CreateMap<Checada, ChecadaDto>().ReverseMap();
            CreateMap<ChecadaAgregada, ChecadaAgregadaDto>().ReverseMap();
            CreateMap<ChecadaRemota, ChecadaRemotaDto>().ReverseMap();
            CreateMap<CompensacionOvertime, CompensacionOvertimeDto>().ReverseMap();
            CreateMap<HoraCategoria, HoraCategoriaDto>().ReverseMap();
            CreateMap<Horario, HorarioDto>().ReverseMap();
            CreateMap<HorarioExcepcion, HorarioExcepcionDto>().ReverseMap();
            CreateMap<HorarioPlantilla, HorarioPlantillaDto>().ReverseMap();
            CreateMap<Incidencia, IncidenciaDto>().ReverseMap();
            CreateMap<PlantillaMensual, PlantillaMensualDto>().ReverseMap();
            CreateMap<PlantillaTurnoDetalle, PlantillaTurnoDetalleDto>().ReverseMap();
            CreateMap<RangoTolerancia, RangoToleranciaDto>().ReverseMap();
            CreateMap<Turno, TurnoDto>().ReverseMap();

            // Biometría
            CreateMap<DispositivoBiometrico, DispositivoBiometricoDto>().ReverseMap();
            CreateMap<LogsSincronizacion, LogsSincronizacionDto>().ReverseMap();
            CreateMap<TipoEventoBiometrico, TipoEventoBiometricoDto>().ReverseMap();

            // Compensaciones
            CreateMap<CatalogoCompensaciones, CatalogoCompensacionesDto>().ReverseMap();
            CreateMap<EmpleadoCompensacion, EmpleadoCompensacionDto>().ReverseMap();
            CreateMap<FondoAhorro, FondoAhorroDto>().ReverseMap();
            CreateMap<MovimientoFondoAhorro, MovimientoFondoAhorroDto>().ReverseMap();
            CreateMap<TabuladorSalarial, TabuladorSalarialDto>().ReverseMap();

            // Configuración
            CreateMap<ConfiguracionGlobal, ConfiguracionGlobalDto>().ReverseMap();
            CreateMap<Modulo, ModuloDto>().ReverseMap();
            CreateMap<ParametroSistema, ParametroSistemaDto>().ReverseMap();
            CreateMap<Politica, PoliticaDto>().ReverseMap();

            // Deducciones
            CreateMap<CatalogoDeducciones, CatalogoDeduccionesDto>().ReverseMap();
            CreateMap<EmpleadoDeduccion, EmpleadoDeduccionDto>().ReverseMap();

            // Fiscal
            CreateMap<CuotaObreroPatronal, CuotaObreroPatronalDto>().ReverseMap();
            CreateMap<TablaImss, TablaImssDto>().ReverseMap();
            CreateMap<TablaInfonavit, TablaInfonavitDto>().ReverseMap();
            CreateMap<TablaIsr, TablaIsrDto>().ReverseMap();
            CreateMap<TablaUma, TablaUmaDto>().ReverseMap();
            CreateMap<TablaVacaciones, TablaVacacionesDto>().ReverseMap();

            // Incidencias
            CreateMap<HistorialIncidencia, HistorialIncidenciaDto>().ReverseMap();
            CreateMap<IncapacidadMedica, IncapacidadMedicaDto>().ReverseMap();
            CreateMap<Justificante, JustificanteDto>().ReverseMap();
            CreateMap<PreNominaIncidencia, PreNominaIncidenciaDto>().ReverseMap();
            CreateMap<TipoIncidencia, TipoIncidenciaDto>().ReverseMap();

            // Nómina
            CreateMap<CentroPagoNomina, CentroPagoNominaDto>().ReverseMap();
            CreateMap<CfdiNomina, CfdiNominaDto>().ReverseMap();
            CreateMap<ConfiguracionNomina, ConfiguracionNominaDto>().ReverseMap();
            CreateMap<DetalleDeducciones, DetalleDeduccionesDto>().ReverseMap();
            CreateMap<DetallePercepciones, DetallePercepcionesDto>().ReverseMap();
            CreateMap<FiniquitoLiquidacion, FiniquitoLiquidacionDto>().ReverseMap();
            CreateMap<PeriodoNomina, PeriodoNominaDto>().ReverseMap();
            CreateMap<ReciboNomina, ReciboNominaDto>().ReverseMap();
            CreateMap<ResponsableNomina, ResponsableNominaDto>().ReverseMap();

            // Organización
            CreateMap<CentroTrabajo, CentroTrabajoDto>().ReverseMap();
            CreateMap<Departamento, DepartamentoDto>().ReverseMap();
            CreateMap<Division, DivisionDto>().ReverseMap();
            CreateMap<EmpresaCentroTrabajo, EmpresaCentroTrabajoDto>().ReverseMap();
            CreateMap<GrupoEmpresa, GrupoEmpresaDto>().ReverseMap();
            CreateMap<Organigrama, OrganigramaDto>().ReverseMap();
            CreateMap<Plaza, PlazaDto>().ReverseMap();
            CreateMap<Puesto, PuestoDto>().ReverseMap();
            CreateMap<Ubicacion, UbicacionDto>().ReverseMap();

            // Prenómina
            CreateMap<ControlCierrePrenomina, ControlCierrePrenominaDto>().ReverseMap();
            CreateMap<HistorialValidacion, HistorialValidacionDto>().ReverseMap();
            CreateMap<TipoPeriodo, TipoPeriodoDto>().ReverseMap();

            // Prestaciones
            CreateMap<CatalogoPrestaciones, CatalogoPrestacionesDto>().ReverseMap();

            // Seguridad
            CreateMap<HistorialRegistroImss, HistorialRegistroImssDto>().ReverseMap();
            CreateMap<Perfil, PerfilDto>().ReverseMap();
            CreateMap<RegistroPatronal, RegistroPatronalDto>().ReverseMap();
            CreateMap<Usuario, UsuarioDto>().ReverseMap();

            // Vacaciones
            CreateMap<PeriodoVacacional, PeriodoVacacionalDto>().ReverseMap();
            CreateMap<Permiso, PermisoDto>().ReverseMap();
            CreateMap<Vacaciones, VacacionesDto>().ReverseMap();
        }
    }
}
