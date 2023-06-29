using System;
using System.Linq;
using System.Collections.Generic;

public class MenuEstadisticas {
	/*
	// TODO public List<File> listaArchivosJugadores { get; set; }
	public List<Jugador> jugadores { get; set; }
	// TODO public File archivoPartidas { get; set; }
	public List<DatosPartida> listaDatosPartidas { get; set; }
	
	public MenuEstadisticas()
	{
		//InitializeComponent();
		
		// TODO cargar la lista de todos los archivos de los jugadores
		// TODO cargar el archivo con las partidas guardadas
		// TODO rellenar jugadores con los datos de los ficheros de los jugadores
		// TODO rellenar listaDatosPartidas del fichero
	}
	
	public void recalcularEstadisticas() {
		// Bucle de partidas
		foreach(DatosPartida datosPartida in listaDatosPartidas) {
			// Bucle de jugadores de las partidas
			foreach(Jugador jugadorPartida in datosPartida.jugadores) {
				Jugador jugador = jugadores.Find(i => i.nombre == jugadorPartida.nombre);
				if(jugador != null) {
					
					jugador.estadisticasGlobales.PartidasJugadas++;
					if(jugadorPartida.datosPartidaJugador.Puesto == 1) {
						jugador.estadisticasGlobales.Victorias++;
					} else {
						jugador.estadisticasGlobales.Derrotas++;
					}
					switch(datosPartida.jugadores.Count) {
						case 2:
							break;
						case 3:
							jugador.estadisticasGlobales.PartidasJugadas3J++;
							jugador.estadisticasGlobales.MediaPuestos3J += jugadorPartida.datosPartidaJugador.Puesto;
							break;
						case 4:
							jugador.estadisticasGlobales.PartidasJugadas4J++;
							jugador.estadisticasGlobales.MediaPuestos4J += jugadorPartida.datosPartidaJugador.Puesto;
							break;
						case 5:
							jugador.estadisticasGlobales.PartidasJugadas5J++;
							jugador.estadisticasGlobales.MediaPuestos5J += jugadorPartida.datosPartidaJugador.Puesto;
							break;
					}
					jugador.estadisticasGlobales.MediaRoleAlcalde += jugadorPartida.datosPartidaJugador.RoleAlcalde;
					jugador.estadisticasGlobales.MediaRoleBuscadorDeOro += jugadorPartida.datosPartidaJugador.RoleBuscadorDeOro;
					jugador.estadisticasGlobales.MediaRoleCapataz += jugadorPartida.datosPartidaJugador.RoleCapataz;
					jugador.estadisticasGlobales.MediaRoleCapitan += jugadorPartida.datosPartidaJugador.RoleCapitan;
					jugador.estadisticasGlobales.MediaRoleColonizador += jugadorPartida.datosPartidaJugador.RoleColonizador;
					jugador.estadisticasGlobales.MediaRoleConstructor += jugadorPartida.datosPartidaJugador.RoleConstructor;
					jugador.estadisticasGlobales.MediaRoleMercader += jugadorPartida.datosPartidaJugador.RoleMercader;
					jugador.estadisticasGlobales.MediaMonedasGanadas += jugadorPartida.datosPartidaJugador.MonedasGanadas;
					jugador.estadisticasGlobales.MediaMonedasGanadasAcumuladasRole += jugadorPartida.datosPartidaJugador.MonedasGanadasAcumuladasRole;
					jugador.estadisticasGlobales.MediaMonedasGastadas += jugadorPartida.datosPartidaJugador.MonedasGastadas;
					jugador.estadisticasGlobales.MediaPVGanados += jugadorPartida.datosPartidaJugador.PVGanados;
					jugador.estadisticasGlobales.MediaEdificiosComprados += jugadorPartida.datosPartidaJugador.EdificiosComprados;
					jugador.estadisticasGlobales.MediaEdificiosFabrica += jugadorPartida.datosPartidaJugador.EdificiosFabrica;
					jugador.estadisticasGlobales.MediaEdificiosLilasNormales += jugadorPartida.datosPartidaJugador.EdificiosLilasNormales;
					jugador.estadisticasGlobales.MediaEdificiosLilasGrandes += jugadorPartida.datosPartidaJugador.EdificiosLilasGrandes;
					jugador.estadisticasGlobales.MediaPlantacionesCogidas += jugadorPartida.datosPartidaJugador.PlantacionesCogidas;
					jugador.estadisticasGlobales.MediaCanterasCogidas += jugadorPartida.datosPartidaJugador.CanterasCogidas;
					jugador.estadisticasGlobales.MediaPlantacionMaizCogido += jugadorPartida.datosPartidaJugador.PlantacionMaizCogido;
					jugador.estadisticasGlobales.MediaPlantacionAnilCogido += jugadorPartida.datosPartidaJugador.PlantacionAnilCogido;
					jugador.estadisticasGlobales.MediaPlantacionAzucarCogido += jugadorPartida.datosPartidaJugador.PlantacionAzucarCogido;
					jugador.estadisticasGlobales.MediaPlantacionTabacoCogido += jugadorPartida.datosPartidaJugador.PlantacionTabacoCogido;
					jugador.estadisticasGlobales.MediaPlantacionCafeCogido += jugadorPartida.datosPartidaJugador.PlantacionCafeCogido;
					jugador.estadisticasGlobales.MediaMaizProducido += jugadorPartida.datosPartidaJugador.MaizProducido;
					jugador.estadisticasGlobales.MediaAnilProducido += jugadorPartida.datosPartidaJugador.AnilProducido;
					jugador.estadisticasGlobales.MediaAzucarProducido += jugadorPartida.datosPartidaJugador.AzucarProducido;
					jugador.estadisticasGlobales.MediaTabacoProducido += jugadorPartida.datosPartidaJugador.TabacoProducido;
					jugador.estadisticasGlobales.MediaCafeProducido += jugadorPartida.datosPartidaJugador.CafeProducido;
					jugador.estadisticasGlobales.MediaColonosConseguidos += jugadorPartida.datosPartidaJugador.ColonosConseguidos;
					jugador.estadisticasGlobales.MediaColonosSanJuan += jugadorPartida.datosPartidaJugador.ColonosSanJuan;
					jugador.estadisticasGlobales.MediaBarrilesVendidos += jugadorPartida.datosPartidaJugador.BarrilesVendidos;
					jugador.estadisticasGlobales.MediaSobreprecioVentas += jugadorPartida.datosPartidaJugador.SobreprecioVentas;
					jugador.estadisticasGlobales.MediaTableroEdificios += jugadorPartida.datosPartidaJugador.TableroEdificios;
					jugador.estadisticasGlobales.MediaTableroPlantaciones += jugadorPartida.datosPartidaJugador.TableroPlantaciones;
					
				}
			}
		}
		
		// Una vez rellenadas las EstadisticasGlobales de la List<Jugadores>,
		// se hará la media de todas las variables
		foreach(Jugadores jugador in jugadores) {
			
			jugador.estadisticasGlobales.MediaVictorias = jugador.estadisticasGlobales.Victorias / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaDerrotas = jugador.estadisticasGlobales.Derrotas / jugador.estadisticasGlobales.PartidasJugadas;
			
			jugador.estadisticasGlobales.MediaPuestos3J = jugador.estadisticasGlobales.MediaPuestos3J / jugador.estadisticasGlobales.PartidasJugadas3J;
			jugador.estadisticasGlobales.MediaPuestos4J = jugador.estadisticasGlobales.MediaPuestos4J / jugador.estadisticasGlobales.PartidasJugadas4J;
			jugador.estadisticasGlobales.MediaPuestos5J = jugador.estadisticasGlobales.MediaPuestos5J / jugador.estadisticasGlobales.PartidasJugadas5J;
			
			jugador.estadisticasGlobales.MediaRoleAlcalde = jugador.estadisticasGlobales.MediaRoleAlcalde / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaRoleBuscadorDeOro = jugador.estadisticasGlobales.MediaRoleBuscadorDeOro / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaRoleCapataz = jugador.estadisticasGlobales.MediaRoleCapataz / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaRoleCapitan = jugador.estadisticasGlobales.MediaRoleCapitan / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaRoleColonizador = jugador.estadisticasGlobales.MediaRoleColonizador / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaRoleConstructor = jugador.estadisticasGlobales.MediaRoleConstructor / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaRoleMercader = jugador.estadisticasGlobales.MediaRoleMercader / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaMonedasGanadas = jugador.estadisticasGlobales.MediaMonedasGanadas / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaMonedasGanadasAcumuladasRole = jugador.estadisticasGlobales.MediaMonedasGanadasAcumuladasRole / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaMonedasGastadas = jugador.estadisticasGlobales.MediaMonedasGastadas / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaPVGanados = jugador.estadisticasGlobales.MediaPVGanados / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaEdificiosComprados = jugador.estadisticasGlobales.MediaEdificiosComprados / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaEdificiosFabrica = jugador.estadisticasGlobales.MediaEdificiosFabrica / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaEdificiosLilasNormales = jugador.estadisticasGlobales.MediaEdificiosLilasNormales / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaEdificiosLilasGrandes = jugador.estadisticasGlobales.MediaEdificiosLilasGrandes / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaPlantacionesCogidas = jugador.estadisticasGlobales.MediaPlantacionesCogidas / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaCanterasCogidas = jugador.estadisticasGlobales.MediaCanterasCogidas / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaPlantacionMaizCogido = jugador.estadisticasGlobales.MediaPlantacionMaizCogido / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaPlantacionAnilCogido = jugador.estadisticasGlobales.MediaPlantacionAnilCogido / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaPlantacionAzucarCogido = jugador.estadisticasGlobales.MediaPlantacionAzucarCogido / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaPlantacionTabacoCogido = jugador.estadisticasGlobales.MediaPlantacionTabacoCogido / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaPlantacionCafeCogido = jugador.estadisticasGlobales.MediaPlantacionCafeCogido / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaMaizProducido = jugador.estadisticasGlobales.MediaMaizProducido / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaAnilProducido = jugador.estadisticasGlobales.MediaAnilProducido / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaAzucarProducido = jugador.estadisticasGlobales.MediaAzucarProducido / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaTabacoProducido = jugador.estadisticasGlobales.MediaTabacoProducido / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaCafeProducido = jugador.estadisticasGlobales.MediaCafeProducido / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaColonosConseguidos = jugador.estadisticasGlobales.MediaColonosConseguidos / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaColonosSanJuan = jugador.estadisticasGlobales.MediaColonosSanJuan / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaBarrilesVendidos = jugador.estadisticasGlobales.MediaBarrilesVendidos / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaSobreprecioVentas = jugador.estadisticasGlobales.MediaSobreprecioVentas / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaTableroEdificios = jugador.estadisticasGlobales.MediaTableroEdificios / jugador.estadisticasGlobales.PartidasJugadas;
			jugador.estadisticasGlobales.MediaTableroPlantaciones = jugador.estadisticasGlobales.MediaTableroPlantaciones / jugador.estadisticasGlobales.PartidasJugadas;
			
			jugador.estadisticasGlobales.guardarArchivoDatos();
		}
	}
	*/
}