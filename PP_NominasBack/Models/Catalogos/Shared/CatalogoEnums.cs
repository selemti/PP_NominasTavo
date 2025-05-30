using System.ComponentModel.DataAnnotations;
using System;
using MongoDB.Bson.Serialization.Attributes;
using System.Xml.Linq;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    // ====================================================
    // 1. Recursos Humanos
    // Gestin de empleados, contratos, plazas y datos personales
    // ====================================================
    #region RH 
    /// <summary>Estado actual del empleado dentro de la organizacin. </summary>
    public enum EstatusEmpleadoEnum
    {
        [Display(Name = "Activo")] Activo = 1,
        [Display(Name = "Vacaciones")] Vacaciones = 2,
        [Display(Name = "Prueba")] Prueba = 3,
        [Display(Name = "Home Office")] HomeOffice = 4,
        [Display(Name = "Suspendido")] Suspendido = 5,
        [Display(Name = "Incapacidad")] Incapacidad = 6,
        [Display(Name = "Comisin")] Comision = 7,
        [Display(Name = "Baja")] Baja = 8,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Motivo por el cual un empleado causa baja.</summary>
    public enum MotivoBajaEnum
    {
        [Display(Name = "Renuncia voluntaria")] Renuncia = 1,
        [Display(Name = "Despido")] Despido = 2,
        [Display(Name = "Jubilacin o retiro")] Jubilacion = 3,
        [Display(Name = "Fallecimiento")] Fallecimiento = 4,
        [Display(Name = "Contrato terminado")] ContratoTerminado = 5,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Tipo de contrato laboral del empleado.</summary>

    public enum TipoContratoEnum
    {
        [Display(Name = "Indeterminado")] Indeterminado = 1,
        [Display(Name = "Determinado")] Determinado = 2,
        [Display(Name = "Por obra o proyecto")] PorObra = 3,
        [Display(Name = "Por temporada")] PorTemporada = 4,
        [Display(Name = "Prueba o capacitacin")] Prueba = 5
    }

    /// <summary>Forma en que se paga al empleado. </summary>
    public enum FormaPagoEnum
    {
        [Display(Name = "Transferencia electrnica")] Transferencia = 1,
        [Display(Name = "Tarjeta de nmina")] TarjetaNomina = 2,
        [Display(Name = "Depsito en ventanilla")] DepositoVentanilla = 3,
        [Display(Name = "Cheque nominativo")] Cheque = 4,
        [Display(Name = "Efectivo")] Efectivo = 5,
        [Display(Name = "Nmina mvil (app)")] NominaMovil = 6,
        [Display(Name = "Otro")] Otro = 99,
        [Display(Name = "Desconocido")] Desconocido = 100
    }

    /// <summary>Tipo de salario del empleado</summary>
    public enum TipoSalarioEnum
    {
        [Display(Name = "No Especificado")] NoEspecificado = 0,
        [Display(Name = "Fijo")] Fijo = 1,
        [Display(Name = "Variable")] Variable = 2,
        [Display(Name = "Mixto")] Mixto = 3
    }

    /// <summary> Estado de una plaza o puesto de trabajo.</summary>
    public enum EstatusPlazaEnum
    {
        [Display(Name = "Vacante")] Vacante = 1,
        [Display(Name = "Ocupada")] Ocupada = 2,
        [Display(Name = "En revisin")] EnRevision = 3,
        [Display(Name = "Suspendida")] Suspendida = 4,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Tipo de centro de trabajo (oficina, planta, sitio remoto).</summary>

    public enum TipoCentroTrabajoEnum
    {
        [Display(Name = "Oficina central")] OficinaCentral = 1,
        [Display(Name = "Planta y taller")] Planta = 2,
        [Display(Name = "Sitio remoto/Sucursal")] Sucursal = 3,
        [Display(Name = "Home Office")] HomeOffice = 4,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Enumeración EstadoCivilEnum.</summary>
    public enum EstadoCivilEnum
    {
        [Display(Name = "Soltero(a)")] Soltero = 1,
        [Display(Name = "Casado(a)")] Casado = 2,
        [Display(Name = "Divorciado(a)")] Divorciado = 3,
        [Display(Name = "Viudo(a)")] Viudo = 4,
        [Display(Name = "Unión Libre")] UnionLibre = 5,
        [Display(Name = "Separado(a)")] Separado = 6
    }

    /// <summary> Enumeración NivelEstudioEnum.</summary>
    public enum NivelEstudioEnum
    {
        [Display(Name = "Ninguno")] Ninguno = 0,
        [Display(Name = "Primaria")] Primaria = 1,
        [Display(Name = "Secundaria")] Secundaria = 2,
        [Display(Name = "Preparatoria o Bachillerato")] Preparatoria = 3,
        [Display(Name = "Técnico o Carrera Comercial")] Tecnico = 4,
        [Display(Name = "Licenciatura")] Licenciatura = 5,
        [Display(Name = "Especialidad")] Especialidad = 6,
        [Display(Name = "Maestría")] Maestria = 7,
        [Display(Name = "Doctorado")] Doctorado = 8
    }

    /// <summary>Sexo biolgico o autodeclarado del empleado.</summary>
    public enum SexoEnum
    {
        [Display(Name = "Masculino")] Masculino = 1,
        [Display(Name = "Femenino")] Femenino = 2,
        [Display(Name = "No especificado")] NoEspecificado = 3,
        [Display(Name = "Otro")] Otro = 4
    }

    /// <summary> Tipo de sangre.</summary>
    public enum TipoSangreEnum
    {
        [Display(Name = "O+")] OPositivo = 1,
        [Display(Name = "O-")] ONegativo = 2,
        [Display(Name = "A+")] APositivo = 3,
        [Display(Name = "A-")] ANegativo = 4,
        [Display(Name = "B+")] BPositivo = 5,
        [Display(Name = "B-")] BNegativo = 6,
        [Display(Name = "AB+")] ABPositivo = 7,
        [Display(Name = "AB-")] ABNegativo = 8
    } 

    /// <summary>Nacionalidad</summary>
    public enum Nacionalidad
    {
        [Display(Name = "Mexicana")]Mexicana = 1,
        [Display(Name = "Estadounidense")]Estadounidense = 2,
        [Display(Name = "Canadiense")]Canadiense = 3,
        [Display(Name = "Española")]Española = 4,
        [Display(Name = "Argentina")]Argentina = 5,
        [Display(Name = "Colombiana")]Colombiana = 6,
        [Display(Name = "Otro")]Otro = 99
    }
    /// <summary>Tipo de número telefónico.</summary>
    public enum TipoTelefono
    {
        [Display(Name = "Celular")]Celular = 1,
        [Display(Name = "Casa")]Casa = 2,
        [Display(Name = "Oficina")]Oficina = 3,
        [Display(Name = "Emergencia")]Emergencia = 4,
        [Display(Name = "Fax")]Fax = 5,
        [Display(Name = "Otro")]Otro = 6
    }

    public enum JornadaLaboralEnum
    {
        [Display(Name = "Tiempo Completo")] TiempoCompleto = 1,
        [Display(Name = "Medio Tiempo")] MedioTiempo = 2,
        [Display(Name = "Por Horas")] PorHoras = 3,
        [Display(Name = "Turnos Extendidos")] TurnosExtendidos = 4,
        [Display(Name = "Jornada Reducida")] JornadaReducida = 5,
        [Display(Name = "Flexible")] Flexible = 6,
        [Display(Name = "Por Días")] PorDias = 7,
        [Display(Name = "Fin de Semana")] FinDeSemana = 8,
        [Display(Name = "Honorarios")] Honorarios = 9,
        [Display(Name = "Otro")] Otro = 99
    }


    #endregion

    #region Asistencia

    // ====================================================
    // 2. Asistencia
    // Registro y tipos de marcaciones
    // ====================================================

    /// <summary>Tipo de evento de checada (entrada/salida/etc.).</summary>
    public enum TipoEventoEnum
    {
        [Display(Name = "Entrada")] Entrada = 1,
        [Display(Name = "Salida")] Salida = 2,
        [Display(Name = "Retardo")] Retardo = 3,
        [Display(Name = "Justificado")] Justificado = 4,
        [Display(Name = "Falta")] Falta = 5,
        [Display(Name = "Reincorporacin")] Reincorporacion = 6,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary> Tipo de horario asociado.</summary>
    public enum TipoHorarioEnum
    {
        [Display(Name = "Diurno")] Diurno = 1,
        [Display(Name = "Nocturno")] Nocturno = 2,
        [Display(Name = "Matutino")] Matutino = 3,
        [Display(Name = "Vespertino")] Vespertino = 4,
        [Display(Name = "Rotativo")] Rotativo = 5,
        [Display(Name = "Flexible")] Flexible = 6,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Clasificacin de das en el calendario.</summary>
    public enum TipoDiaEnum
    {
        [Display(Name = "Laboral")] Laboral = 1,
        [Display(Name = "Descanso")] Descanso = 2,
        [Display(Name = "Festivo oficial")] Festivo = 3,
        [Display(Name = "Compensatorio")] Compensatorio = 4,
        [Display(Name = "Catorcenal (14 das)")] Catorcenal = 5
    }

    /// <summary>Tipo de dispositivo de marcacin.</summary>
    public enum TipoDispositivoEnum
    {
        [Display(Name = "Biomtrico")] Biometrico = 1,
        [Display(Name = "Mvil")] Movil = 2,
        [Display(Name = "Web")] Web = 3,
        [Display(Name = "Otro")] Otro = 99
    }

    #endregion

    #region Incidencia y Permisos
    // ====================================================
    // 3. Incidencias y Permisos
    // Justificantes, incapacidades y reposiciones
    // ====================================================

    /// <summary>Tipos de justificantes que un empleado puede presentar.</summary>

    public enum TipoJustificanteEnum
    {
        [Display(Name = "Mdico")] Medico = 1,
        [Display(Name = "Vacaciones")] Vacaciones = 2,
        [Display(Name = "Personal")] Personal = 3,
        [Display(Name = "Judicial")] Judicial = 4,
        [Display(Name = "Acadmico")] Academico = 5,
        [Display(Name = "Fallecimiento")] Fallecimiento = 6,
        [Display(Name = "Otro")] Otro = 99,
        [Display(Name = "Desconocido")] Desconocido = 100
    }

    /// <summary>Tipos de incapacidades registrados.</summary>

    public enum TipoIncapacidadEnum
    {
        [Display(Name = "Enfermedad general")] EnfermedadGeneral = 1,
        [Display(Name = "Riesgo de trabajo")] RiesgoTrabajo = 2,
        [Display(Name = "Maternidad")] Maternidad = 3,
        [Display(Name = "Paternidad")] Paternidad = 4,
        [Display(Name = "COVID")] COVID = 5,
        [Display(Name = "Otro")] Otro = 99,
        [Display(Name = "Desconocido")] Desconocido = 100
    }

    /// <summary>Permisos y tipos de reposicin de tiempo.</summary>

    public enum TipoPermisoEnum
    {
        [Display(Name = "Con goce de sueldo")] ConGoce = 1,
        [Display(Name = "Sin goce de sueldo")] SinGoce = 2,
        [Display(Name = "Por horas")] PorHoras = 3,
        [Display(Name = "Anticipado")] Anticipado = 4,
        [Display(Name = "Estudio")] Estudio = 5,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Modalidades de reposicin de tiempo.</summary>
    public enum ModalidadReposicionEnum
    {
        [Display(Name = "Tiempo extra")] TiempoExtra = 1,
        [Display(Name = "Da compensatorio")] DiaCompensatorio = 2,
        [Display(Name = "No requiere")] NoRequiere = 3
    }

    #endregion

    #region Nomina y Finanzas
    // ====================================================
    // 4. Nmina y Finanzas
    // Ciclos, percepciones, deducciones y descuentos
    // ====================================================

    /// <summary>Tipo de Nómina.</summary>
    public enum TipoNominaEnum
    {
        [Display(Name = "Ordinaria")] Ordinaria = 1,
        [Display(Name = "Extraordinaria")] Extraordinaria = 2,
        [Display(Name = "Finiquito")] Finiquito = 3,
        [Display(Name = "Liquidacin")] Liquidacion = 4
    }

    /// <summary>
    /// Frecuencia de pago y cierre.
    /// </summary>

    public enum PeriodicidadEnum
    {
        [Display(Name = "Quincenal")] Quincenal = 1,
        [Display(Name = "Semanal")] Semanal = 2,
        [Display(Name = "Catorcenal")] Catorcenal = 3,
        [Display(Name = "Mensual")] Mensual = 4,
        [Display(Name = "Diario")] Diario = 5,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>
    /// Mes del ao.
    /// </summary>

    public enum PeriodoEnum
    {
        [Display(Name = "Enero")] Enero = 1,
        [Display(Name = "Febrero")] Febrero = 2,
        [Display(Name = "Marzo")] Marzo = 3,
        [Display(Name = "Abril")] Abril = 4,
        [Display(Name = "Mayo")] Mayo = 5,
        [Display(Name = "Junio")] Junio = 6,
        [Display(Name = "Julio")] Julio = 7,
        [Display(Name = "Agosto")] Agosto = 8,
        [Display(Name = "Septiembre")] Septiembre = 9,
        [Display(Name = "Octubre")] Octubre = 10,
        [Display(Name = "Noviembre")] Noviembre = 11,
        [Display(Name = "Diciembre")] Diciembre = 12
    }

    /// <summary>
    /// Tipo de fiscalizacin de CFDI.
    /// </summary>

    public enum TipoFiscalizacionEnum
    {
        [Display(Name = "Normal")] Normal = 1,
        [Display(Name = "Complementaria")] Complementaria = 2,
        [Display(Name = "Sustitutiva")] Sustitutiva = 3
    }

    /// <summary>
    /// Conceptos de percepciones y compensaciones.
    /// </summary>

    public enum TipoCompensacionEnum
    {
        [Display(Name = "Comisin")] Comision = 1,
        [Display(Name = "Bono")] Bono = 2,
        [Display(Name = "Vales")] Vales = 3,
        [Display(Name = "Prestacin")] Prestacion = 4,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>
    /// Tipos de deducciones fiscales y voluntarias.
    /// </summary>

    public enum TipoDeduccionEnum
    {
        [Display(Name = "ISR")] ISR = 1,
        [Display(Name = "IMSS")] IMSS = 2,
        [Display(Name = "Infonavit")] Infonavit = 3,
        [Display(Name = "Prstamo")] Prestamo = 4,
        [Display(Name = "Fondo de ahorro obligatorio")] FondoAhorroObligatorio = 5,
        [Display(Name = "Pensiones alimenticias")] PensionesAlimenticias = 6,
        [Display(Name = "Aportacin voluntaria")] AportacionVoluntaria = 7,
        [Display(Name = "Aportacin patronal")] AportacionPatronal = 8,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>
    /// Formas de aplicar descuentos.
    /// </summary>

    public enum TipoDescuentoEnum
    {
        [Display(Name = "Porcentaje")] Porcentaje = 1,
        [Display(Name = "Cantidad fija")] CantidadFija = 2
    }

    #endregion
    // ====================================================
    // 5. Seguridad y Notificaciones
    // Permisos de usuario y alertas
    // ====================================================

    #region Seguridad y Notificaciones
    /// <summary>
    /// Estados posibles de un usuario del sistema.
    /// </summary>

    public enum EstatusUsuarioEnum
    {
        [Display(Name = "Activo")] Activo = 1,
        [Display(Name = "Suspendido")] Suspendido = 2,
        [Display(Name = "Inactivo")] Inactivo = 3,
        [Display(Name = "Bloqueado")] Bloqueado = 4
    }

    /// <summary>
    /// Roles de responsabilidad en flujos y aprobaciones.
    /// </summary>
    public enum TipoResponsabilidadEnum
    {
        [Display(Name = "Administrador")] Administrador = 1,
        [Display(Name = "Supervisor")] Supervisor = 2,
        [Display(Name = "Empleado")] Empleado = 3
    }

    /// <summary>
    /// Categora de destinatarios para alertas.
    /// </summary>

    public enum TipoDestinatarioEnum
    {
        [Display(Name = "Empleado")] Empleado = 1,
        [Display(Name = "Supervisor")] Supervisor = 2,
        [Display(Name = "Departamento")] Departamento = 3,
        [Display(Name = "Global")] Global = 4,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>
    /// Tipos de responsables al enviar notificaciones.
    /// </summary>

    public enum TipoResponsableEnum
    {
        [Display(Name = "Usuario")] Usuario = 1,
        [Display(Name = "Perfil")] Perfil = 2,
        [Display(Name = "Sistema")] Sistema = 3
    }

    /// <summary>
    /// Medios disponibles para envo de alertas y notificaciones.
    /// </summary>

    public enum MedioEnvioEnum
    {
        [Display(Name = "Correo electrnico")] Correo = 1,
        [Display(Name = "WhatsApp")] Whatsapp = 2,
        [Display(Name = "SMS")] SMS = 3,
        [Display(Name = "Portal de empleado")] Portal = 4,
        [Display(Name = "Otro")] Otro = 99
    }

    #endregion

    #region Micelaneos
    // ====================================================
    // 6. Miscelneos
    // Otras asignaciones y configuraciones varias
    // ====================================================

    /// <summary>Tipos de asignaciones automticas o manuales.</summary>
    public enum TipoAsignacionEnum
    {
        [Display(Name = "Automtica")] Automatica = 1,
        [Display(Name = "Manual")] Manual = 2,
        [Display(Name = "Otro")] Otro = 99
    
    }
    #endregion
}
