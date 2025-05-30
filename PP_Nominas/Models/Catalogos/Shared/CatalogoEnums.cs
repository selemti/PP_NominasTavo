using System;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Shared
{
    // ====================================================
    // 1. Recursos Humanos
    // ====================================================
    #region RH
    /// <summary>Estado actual del empleado dentro de la organización.</summary>
    public enum EstatusEmpleadoEnum
    {
        [Display(Name = "Activo")] Activo = 1,
        [Display(Name = "Vacaciones")] Vacaciones = 2,
        [Display(Name = "Prueba")] Prueba = 3,
        [Display(Name = "Home Office")] HomeOffice = 4,
        [Display(Name = "Suspendido")] Suspendido = 5,
        [Display(Name = "Incapacidad")] Incapacidad = 6,
        [Display(Name = "Comisión")] Comision = 7,
        [Display(Name = "Baja")] Baja = 8,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Motivo por el cual un empleado causa baja.</summary>
    public enum MotivoBajaEnum
    {
        [Display(Name = "Renuncia voluntaria")] Renuncia = 1,
        [Display(Name = "Despido")] Despido = 2,
        [Display(Name = "Jubilación o retiro")] Jubilacion = 3,
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
        [Display(Name = "Prueba o capacitación")] Prueba = 5
    }

    /// <summary>Forma en que se paga al empleado.</summary>
    public enum FormaPagoEnum
    {
        [Display(Name = "Transferencia electrónica")] Transferencia = 1,
        [Display(Name = "Tarjeta de nómina")] TarjetaNomina = 2,
        [Display(Name = "Depósito en ventanilla")] DepositoVentanilla = 3,
        [Display(Name = "Cheque nominativo")] Cheque = 4,
        [Display(Name = "Efectivo")] Efectivo = 5,
        [Display(Name = "Nómina móvil (app)")] NominaMovil = 6,
        [Display(Name = "Otro")] Otro = 99,
        [Display(Name = "Desconocido")] Desconocido = 100
    }

    /// <summary>Tipo de salario que recibe el colaborador.</summary>
    public enum TipoSalarioEnum
    {
        [Display(Name = "No Especificado")] NoEspecificado = 0,
        [Display(Name = "Fijo")] Fijo = 1,
        [Display(Name = "Variable")] Variable = 2,
        [Display(Name = "Mixto")] Mixto = 3
    }

    /// <summary>Estado civil declarado del colaborador.</summary>
    public enum EstadoCivilEnum
    {
        [Display(Name = "Soltero(a)")] Soltero = 1,
        [Display(Name = "Casado(a)")] Casado = 2,
        [Display(Name = "Divorciado(a)")] Divorciado = 3,
        [Display(Name = "Viudo(a)")] Viudo = 4,
        [Display(Name = "Unión Libre")] UnionLibre = 5,
        [Display(Name = "Separado(a)")] Separado = 6
    }

    /// <summary>Máximo nivel de estudios alcanzado.</summary>
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

    /// <summary>Sexo biológico o autodeclarado del empleado.</summary>
    public enum SexoEnum
    {
        [Display(Name = "Masculino")] Masculino = 1,
        [Display(Name = "Femenino")] Femenino = 2,
        [Display(Name = "No especificado")] NoEspecificado = 3,
        [Display(Name = "Otro")] Otro = 4
    }

    /// <summary>Tipo de sangre registrado.</summary>
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

    /// <summary>Nacionalidad del empleado.</summary>
    public enum Nacionalidad
    {
        [Display(Name = "Mexicana")] Mexicana = 1,
        [Display(Name = "Estadounidense")] Estadounidense = 2,
        [Display(Name = "Canadiense")] Canadiense = 3,
        [Display(Name = "Española")] Española = 4,
        [Display(Name = "Argentina")] Argentina = 5,
        [Display(Name = "Colombiana")] Colombiana = 6,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Tipo de número telefónico declarado.</summary>
    public enum TipoTelefono
    {
        [Display(Name = "Celular")] Celular = 1,
        [Display(Name = "Casa")] Casa = 2,
        [Display(Name = "Oficina")] Oficina = 3,
        [Display(Name = "Emergencia")] Emergencia = 4,
        [Display(Name = "Fax")] Fax = 5,
        [Display(Name = "Otro")] Otro = 6
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
    // ====================================================

    /// <summary>Tipo de evento de checada (entrada, salida, etc.).</summary>
    public enum TipoEventoEnum
    {
        [Display(Name = "Entrada")] Entrada = 1,
        [Display(Name = "Salida")] Salida = 2,
        [Display(Name = "Retardo")] Retardo = 3,
        [Display(Name = "Justificado")] Justificado = 4,
        [Display(Name = "Falta")] Falta = 5,
        [Display(Name = "Reincorporación")] Reincorporacion = 6,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Tipo de horario asignado.</summary>
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

    /// <summary>Clasificación de días en el calendario laboral.</summary>
    public enum TipoDiaEnum
    {
        [Display(Name = "Laboral")] Laboral = 1,
        [Display(Name = "Descanso")] Descanso = 2,
        [Display(Name = "Festivo oficial")] Festivo = 3,
        [Display(Name = "Compensatorio")] Compensatorio = 4,
        [Display(Name = "Catorcenal")] Catorcenal = 5
    }

    /// <summary>Tipo de dispositivo desde donde se registran asistencias.</summary>
    public enum TipoDispositivoEnum
    {
        [Display(Name = "Biométrico")] Biometrico = 1,
        [Display(Name = "Móvil")] Movil = 2,
        [Display(Name = "Web")] Web = 3,
        [Display(Name = "Otro")] Otro = 99
    }
    /// <summary>Estado de una plaza o puesto de trabajo.</summary>
    public enum EstatusPlazaEnum
    {
        [Display(Name = "Vacante")] Vacante = 1,
        [Display(Name = "Ocupada")] Ocupada = 2,
        [Display(Name = "En revisión")] EnRevision = 3,
        [Display(Name = "Suspendida")] Suspendida = 4,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Tipo de centro de trabajo asignado.</summary>
    public enum TipoCentroTrabajoEnum
    {
        [Display(Name = "Oficina central")] OficinaCentral = 1,
        [Display(Name = "Planta y taller")] Planta = 2,
        [Display(Name = "Sitio remoto/Sucursal")] Sucursal = 3,
        [Display(Name = "Home Office")] HomeOffice = 4,
        [Display(Name = "Otro")] Otro = 99
    }

    #endregion

    #region Incidencias y Permisos


    // ====================================================
    // 3. Incidencias y permisos
    // ====================================================

    /// <summary>Tipo de justificante entregado por el empleado.</summary>
    public enum TipoJustificanteEnum
    {
        [Display(Name = "Médico")] Medico = 1,
        [Display(Name = "Vacaciones")] Vacaciones = 2,
        [Display(Name = "Personal")] Personal = 3,
        [Display(Name = "Judicial")] Judicial = 4,
        [Display(Name = "Académico")] Academico = 5,
        [Display(Name = "Fallecimiento")] Fallecimiento = 6,
        [Display(Name = "Otro")] Otro = 99,
        [Display(Name = "Desconocido")] Desconocido = 100
    }

    /// <summary>Tipo de incapacidad médica.</summary>
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

    /// <summary>Tipo de permiso solicitado por el colaborador.</summary>
    public enum TipoPermisoEnum
    {
        [Display(Name = "Con goce de sueldo")] ConGoce = 1,
        [Display(Name = "Sin goce de sueldo")] SinGoce = 2,
        [Display(Name = "Por horas")] PorHoras = 3,
        [Display(Name = "Anticipado")] Anticipado = 4,
        [Display(Name = "Estudio")] Estudio = 5,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Forma en que se repondrá el tiempo no trabajado.</summary>
    public enum ModalidadReposicionEnum
    {
        [Display(Name = "Tiempo extra")] TiempoExtra = 1,
        [Display(Name = "Día compensatorio")] DiaCompensatorio = 2,
        [Display(Name = "No requiere")] NoRequiere = 3
    }

    #endregion

    #region Nomina y Finanzas

    // ====================================================
    // 4. Nómina y finanzas
    // ====================================================

    /// <summary>Tipo de nómina a procesar.</summary>
    public enum TipoNominaEnum
    {
        [Display(Name = "Ordinaria")] Ordinaria = 1,
        [Display(Name = "Extraordinaria")] Extraordinaria = 2,
        [Display(Name = "Finiquito")] Finiquito = 3,
        [Display(Name = "Liquidación")] Liquidacion = 4
    }

    /// <summary>Frecuencia de pago del colaborador.</summary>
    public enum PeriodicidadEnum
    {
        [Display(Name = "Quincenal")] Quincenal = 1,
        [Display(Name = "Semanal")] Semanal = 2,
        [Display(Name = "Catorcenal")] Catorcenal = 3,
        [Display(Name = "Mensual")] Mensual = 4,
        [Display(Name = "Diario")] Diario = 5,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Mes calendario dentro del ejercicio fiscal.</summary>
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

    /// <summary>Tipo de fiscalización de CFDI.</summary>
    public enum TipoFiscalizacionEnum
    {
        [Display(Name = "Normal")] Normal = 1,
        [Display(Name = "Complementaria")] Complementaria = 2,
        [Display(Name = "Sustitutiva")] Sustitutiva = 3
    }

    /// <summary>Categoría de compensaciones otorgadas al colaborador.</summary>
    public enum TipoCompensacionEnum
    {
        [Display(Name = "Comisión")] Comision = 1,
        [Display(Name = "Bono")] Bono = 2,
        [Display(Name = "Vales")] Vales = 3,
        [Display(Name = "Prestación")] Prestacion = 4,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Tipo de deducción aplicada al colaborador.</summary>
    public enum TipoDeduccionEnum
    {
        [Display(Name = "ISR")] ISR = 1,
        [Display(Name = "IMSS")] IMSS = 2,
        [Display(Name = "Infonavit")] Infonavit = 3,
        [Display(Name = "Préstamo")] Prestamo = 4,
        [Display(Name = "Fondo de ahorro obligatorio")] FondoAhorroObligatorio = 5,
        [Display(Name = "Pensiones alimenticias")] PensionesAlimenticias = 6,
        [Display(Name = "Aportación voluntaria")] AportacionVoluntaria = 7,
        [Display(Name = "Aportación patronal")] AportacionPatronal = 8,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Modalidad con la que se aplica un descuento.</summary>
    public enum TipoDescuentoEnum
    {
        [Display(Name = "Porcentaje")] Porcentaje = 1,
        [Display(Name = "Cantidad fija")] CantidadFija = 2
    }

    #endregion

    #region Seguridad y Notificaciones

    // ====================================================
    // 5. Seguridad y notificaciones
    // ====================================================

    /// <summary>Estatus del usuario en el sistema.</summary>
    public enum EstatusUsuarioEnum
    {
        [Display(Name = "Activo")] Activo = 1,
        [Display(Name = "Suspendido")] Suspendido = 2,
        [Display(Name = "Inactivo")] Inactivo = 3,
        [Display(Name = "Bloqueado")] Bloqueado = 4
    }

    /// <summary>Tipo de responsabilidad asignada.</summary>
    public enum TipoResponsabilidadEnum
    {
        [Display(Name = "Administrador")] Administrador = 1,
        [Display(Name = "Supervisor")] Supervisor = 2,
        [Display(Name = "Empleado")] Empleado = 3
    }

    /// <summary>Categoría del destinatario de la notificación.</summary>
    public enum TipoDestinatarioEnum
    {
        [Display(Name = "Empleado")] Empleado = 1,
        [Display(Name = "Supervisor")] Supervisor = 2,
        [Display(Name = "Departamento")] Departamento = 3,
        [Display(Name = "Global")] Global = 4,
        [Display(Name = "Otro")] Otro = 99
    }

    /// <summary>Origen del responsable de ejecutar una acción.</summary>
    public enum TipoResponsableEnum
    {
        [Display(Name = "Usuario")] Usuario = 1,
        [Display(Name = "Perfil")] Perfil = 2,
        [Display(Name = "Sistema")] Sistema = 3
    }

    /// <summary>Medio utilizado para enviar notificaciones.</summary>
    public enum MedioEnvioEnum
    {
        [Display(Name = "Correo electrónico")] Correo = 1,
        [Display(Name = "WhatsApp")] Whatsapp = 2,
        [Display(Name = "SMS")] SMS = 3,
        [Display(Name = "Portal de empleado")] Portal = 4,
        [Display(Name = "Otro")] Otro = 99
    }

    public enum TipoAlertaEnum
    {
        [Display(Name = "Informativa")] Informativa = 1,
        [Display(Name = "Advertencia")] Advertencia = 2,
        [Display(Name = "Error")] Error = 3,
        [Display(Name = "Validación requerida")] Validacion = 4
    }

    public enum EstadoPasoFlujoEnum
    {
        [Display(Name = "Pendiente")] Pendiente = 1,
        [Display(Name = "Aprobado")] Aprobado = 2,
        [Display(Name = "Rechazado")] Rechazado = 3,
        [Display(Name = "Cancelado")] Cancelado = 4
    }

    public enum TipoPeriodicidadEnum
    {
        [Display(Name = "Única vez")] Unica = 1,
        [Display(Name = "Diaria")] Diaria = 2,
        [Display(Name = "Semanal")] Semanal = 3,
        [Display(Name = "Mensual")] Mensual = 4
    }

    #endregion

    #region Miselaneos
    // ====================================================
    // 6. Misceláneos
    // ====================================================

    /// <summary>Tipo de asignación automática o manual.</summary>
    public enum TipoAsignacionEnum
    {
        [Display(Name = "Automática")] Automatica = 1,
        [Display(Name = "Manual")] Manual = 2,
        [Display(Name = "Otro")] Otro = 99
    }

    #endregion
}