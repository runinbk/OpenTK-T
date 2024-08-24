using System;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Proyecto1
{
    public class T
    {
        private float ancho;
        private float alto;
        private float profundidad;
        public Punto origen;

        public T(Punto p, float ancho, float alto, float profundidad)
        {
            origen = p;
            this.ancho = ancho;
            this.alto = alto;
            this.profundidad = profundidad;
        }

        public void Dibujar()
        {
            GL.Rotate(20, 1, 1, 0);  // Rotación similar a la que usas en la clase Cubo
            PrimitiveType primitiveType = PrimitiveType.LineLoop;

            // Dibujar las partes frontal y trasera de la letra T
            DibujarParteFrontal(primitiveType);
            DibujarParteTrasera(primitiveType);

            // Conectar las caras frontal y trasera para crear los lados de la letra T
            ConectarCaras(primitiveType);

        }

        private void DibujarParteFrontal(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1.0, 1.0, 0.0); // Amarillo

            // Barra horizontal superior (parte frontal)
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z + profundidad); // Izquierda superior
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z + profundidad); // Derecha superior
            GL.Vertex3(origen.x + ancho, origen.y + alto * 0.5f, origen.z + profundidad); // Derecha medio
            GL.Vertex3(origen.x - ancho, origen.y + alto * 0.5f, origen.z + profundidad); // Izquierda medio

            // Barra vertical inferior (parte frontal)
            GL.Vertex3(origen.x - ancho * 0.25f, origen.y + alto * 0.5f, origen.z + profundidad); // Izquierda medio
            GL.Vertex3(origen.x + ancho * 0.25f, origen.y + alto * 0.5f, origen.z + profundidad); // Derecha medio
            GL.Vertex3(origen.x + ancho * 0.25f, origen.y - alto, origen.z + profundidad); // Derecha inferior
            GL.Vertex3(origen.x - ancho * 0.25f, origen.y - alto, origen.z + profundidad); // Izquierda inferior

            GL.End();
        }

        private void DibujarParteTrasera(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(0.0, 1.0, 0.0); // Verde

            // Barra horizontal superior (parte trasera)
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z - profundidad); // Izquierda superior
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z - profundidad); // Derecha superior
            GL.Vertex3(origen.x + ancho, origen.y + alto * 0.5f, origen.z - profundidad); // Derecha medio
            GL.Vertex3(origen.x - ancho, origen.y + alto * 0.5f, origen.z - profundidad); // Izquierda medio

            // Barra vertical inferior (parte trasera)
            GL.Vertex3(origen.x - ancho * 0.25f, origen.y + alto * 0.5f, origen.z - profundidad); // Izquierda medio
            GL.Vertex3(origen.x + ancho * 0.25f, origen.y + alto * 0.5f, origen.z - profundidad); // Derecha medio
            GL.Vertex3(origen.x + ancho * 0.25f, origen.y - alto, origen.z - profundidad); // Derecha inferior
            GL.Vertex3(origen.x - ancho * 0.25f, origen.y - alto, origen.z - profundidad); // Izquierda inferior

            GL.End();
        }

        private void ConectarCaras(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1.0, 0.0, 1.0); // Rosado

            // Conectar la parte superior izquierda (frontal y trasera)
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z + profundidad); // Frontal izquierda superior
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z - profundidad); // Trasera izquierda superior

            // Conectar la parte superior derecha (frontal y trasera)
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z + profundidad); // Frontal derecha superior
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z - profundidad); // Trasera derecha superior

            // Conectar la parte media izquierda (frontal y trasera)
            GL.Vertex3(origen.x - ancho, origen.y + alto * 0.5f, origen.z + profundidad); // Frontal izquierda medio
            GL.Vertex3(origen.x - ancho, origen.y + alto * 0.5f, origen.z - profundidad); // Trasera izquierda medio

            // Conectar la parte media derecha (frontal y trasera)
            GL.Vertex3(origen.x + ancho, origen.y + alto * 0.5f, origen.z + profundidad); // Frontal derecha medio
            GL.Vertex3(origen.x + ancho, origen.y + alto * 0.5f, origen.z - profundidad); // Trasera derecha medio

            // Conectar la parte inferior izquierda (frontal y trasera)
            GL.Vertex3(origen.x - ancho * 0.25f, origen.y - alto, origen.z + profundidad); // Frontal izquierda inferior
            GL.Vertex3(origen.x - ancho * 0.25f, origen.y - alto, origen.z - profundidad); // Trasera izquierda inferior

            // Conectar la parte inferior derecha (frontal y trasera)
            GL.Vertex3(origen.x + ancho * 0.25f, origen.y - alto, origen.z + profundidad); // Frontal derecha inferior
            GL.Vertex3(origen.x + ancho * 0.25f, origen.y - alto, origen.z - profundidad); // Trasera derecha inferior

            GL.End();
        }
    }
}
