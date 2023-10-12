using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este namespace tiene los diferentes eventos propios que utilizaremos para el juego
namespace MoreMountains.Yo
{

    public enum AccionCambioVida { Añadir, Quitar, Setear }

    public enum recogibles{ Llave, Moneda, General}

    public struct EventoCambiarVida
    {
        public Character personajeObjetivo;
        public AccionCambioVida tipoAccion;
        public int cantidad;

        public EventoCambiarVida(Character _PersonajeObjetivo, AccionCambioVida _TipoAccion, int _cantidad)
        {
            personajeObjetivo = _PersonajeObjetivo;
            tipoAccion = _TipoAccion;
            cantidad = _cantidad;
        }

        static EventoCambiarVida e;
        public static void Trigger(Character _PersonajeObjetivo, AccionCambioVida _TipoAccion, int _cantidad)
        {
            e.personajeObjetivo = _PersonajeObjetivo;
            e.tipoAccion = _TipoAccion;
            e.cantidad = _cantidad;
        }
    }

    public struct EventoPickable
    {
        public Character recolector;
        public recogibles tipoRecogible;

        public EventoPickable(Character _recolector, recogibles _tipoRecogible)
        {
            recolector = _recolector;
            tipoRecogible = _tipoRecogible;
        }

        static EventoPickable e;

        public static void Trigger(Character _recolector, recogibles _tipoRecogible)
        {
            e.recolector = _recolector;
            e.tipoRecogible = _tipoRecogible;
            MMEventManager.TriggerEvent(e);
        }
    }
}
