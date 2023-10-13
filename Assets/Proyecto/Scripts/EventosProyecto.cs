using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este namespace tiene los diferentes eventos propios que utilizaremos para el juego
namespace MoreMountains.Yo
{
    public enum recogibles{ Llave, Moneda, General}

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

    public struct EventoEnemigo
    {
        public Enemigos enemigo;
        public string nombre;

        public EventoEnemigo(Enemigos _enemigo, string _nombre)
        {
            enemigo = _enemigo;
            nombre = _nombre;
        }

        static EventoEnemigo e;

        public static void Trigger(Enemigos _enemigo, string _nombre)
        {
            e.enemigo = _enemigo;
            e.nombre = _nombre;
            MMEventManager.TriggerEvent(e);
        }
    }
}
