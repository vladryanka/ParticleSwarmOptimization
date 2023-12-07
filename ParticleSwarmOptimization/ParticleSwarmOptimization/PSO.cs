using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarmOptimization
{
    class PSO
    {
        private List<Particle> particles;
        private double[] globalBestPosition;
        private double globalBestValue;

        internal Particle Particle
        {
            get => default;
            set
            {
            }
        }

        public void InitializeSwarm(int NumParticles, int function, double[] upperBound, double[] lowerBound, int depend)
        {
            // Создание списка частиц
            particles = new List<Particle>();

            // Инициализация каждой частицы
            for (int i = 0; i < NumParticles; i++)
            {
                Particle particle = new Particle();

                // Генерация начального положения и скорости
                particle.Position = new double[3]; // Для трехмерной функции
                particle.Velocity = new double[3]; // Для трехмерной функции
                for (int j = 0; j < depend; j++) // Для трехмерной функции
                {
                    particle.Position[j] = GetRandomValue() * (upperBound[j] - lowerBound[j]) + lowerBound[j];
                    particle.Velocity[j] = GetRandomValueInRange(0, 1);
                }

                // Инициализация начального значения функции
                particle.BestPosition = particle.Position;
                particle.BestValue = ObjectiveFunction(particle.Position, function);

                // Добавление частицы в список
                particles.Add(particle);
            }

            // Инициализация глобального наилучшего положения
            globalBestPosition = new double[depend];
            globalBestValue = double.MaxValue;
        }
        public double[] RunOptimization(int MaxIterations, double cogComp, double socComp, int function, double[] upperBound, double[] lowerBound, int depend)
        {
            Random random = new Random();
            for (int iteration = 0; iteration < MaxIterations; iteration++)
            {
                // Обновление каждой частицы
                foreach (Particle particle in particles)
                {
                    // Расчет новой скорости
                    for (int i = 0; i < depend; i++) // Для трехмерной функции
                    {
                        double k1 = random.NextDouble();
                        double k2 = random.NextDouble();
                        double cognitiveComponent = cogComp * k1 * (particle.BestPosition[i] - particle.Position[i]);
                        double socialComponent = socComp * k2 * (globalBestPosition[i] - particle.Position[i]);

                        particle.Velocity[i] += cognitiveComponent + socialComponent;
                    }

                    // Обновление положения частицы
                    for (int i = 0; i < depend; i++) // Для трехмерной функции
                    {
                        particle.Position[i] += particle.Velocity[i];
                        if (particle.Position[i] < lowerBound[i])
                            particle.Position[i] = lowerBound[i];
                        if (particle.Position[i] > upperBound[i])
                            particle.Position[i] = upperBound[i];
                    }

                    // Вычисление значения функции в новом положении
                    double newValue = ObjectiveFunction(particle.Position, function);

                    // Обновление наилучшего положения частицы и
                    // глобального наилучшего положения
                    if (newValue < globalBestValue)
                    {
                        globalBestValue = newValue;
                        Array.Copy(particle.Position, globalBestPosition, depend);
                    }
                    if (newValue < particle.BestValue)
                    {
                        Array.Copy(particle.Position, particle.BestPosition, depend);
                        particle.BestValue = newValue;
                    }
                }
            }
            return globalBestPosition;
        }

        private double ObjectiveFunction(double[] position, int function)
        {
            double result = 0;
            switch (function)
            {
                case 1:
                    {
                        result = (position[0] - 3) * (position[0] - 3);
                        break;
                    }
                case 2:
                    {
                        result = 100 * (position[1] - position[0] * position[0]) * (position[1] - position[0] * position[0]) + (1 - position[0]) * (1 - position[0]);
                        break;
                    }
                default:
                    {
                        result = (position[0] - 1) * (position[0] - 1) + (position[1] - 3) * (position[1] - 3) + 4 * (position[2] + 5) * (position[2] + 5);
                        break;
                    }
            }
            return result;

        }

        private double GetRandomValueInRange(double minValue, double maxValue)
        {
            Random random = new Random();
            return minValue + random.NextDouble() * (maxValue - minValue);
        }

        private double GetRandomValue()
        {
            Random random = new Random();
            return random.NextDouble();
        }
    }
}

