using Microsoft.VisualStudio.TestTools.UnitTesting;
using CovalcoWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovalcoWebApi.Models;
using System.Web.Http;
using System.Web.Http.Results;

namespace CovalcoWebApi.Controllers.Tests
{
	[TestClass()]
	public class AlumnosControllerTests
	{
		[TestMethod()]
		public void GetAlumnoTest()
		{
			AlumnosController controller = new AlumnosController();
			IQueryable<Alumno> alumnos = controller.GetAlumno();
			Assert.IsTrue(alumnos.Count<Alumno>() > 0);
		}

		[TestMethod()]
		public void GetAlumnoTest1()
		{
			AlumnosController controller = new AlumnosController();
			IHttpActionResult actionResult = controller.GetAlumno(1);

			var contentResult = actionResult as OkNegotiatedContentResult<Alumno>;
			Assert.IsNotNull(contentResult);
			Assert.IsNotNull(contentResult.Content);
			Assert.AreEqual(1, contentResult.Content.Id);
		}

		[TestMethod()]
		public void PutAlumnoTest()
		{
			AlumnosController controller = new AlumnosController();
			IHttpActionResult actionResult = controller.PutAlumno(1,
				new
				Alumno { Id = 1, Nombre = "TestName4", Apellidos = "TestSurname4",
					Dni = "123" });
			Assert.IsNotNull(actionResult);
			
		}

		[TestMethod()]
		public void PostAlumnoTest()
		{
			AlumnosController controller = new AlumnosController();
			IHttpActionResult actionResult =
				controller.PostAlumno(
					new Alumno { Nombre = "Ferran",
						Apellidos = "Ferrer", Dni = "54321" });

			var contentResult =	actionResult as	CreatedAtRouteNegotiatedContentResult<Alumno>;

			Assert.IsNotNull(actionResult);
			Assert.IsTrue(contentResult.RouteName == "DefaultApi");
		}

		[TestMethod()]
		public void DeleteAlumnoTest()
		{
			AlumnosController controller = new AlumnosController();
			IHttpActionResult actionResult =
				controller.PostAlumno(
					new Alumno
					{
						Nombre = "Ferran",
						Apellidos = "Ferrer",
						Dni = "54321"
					});

			var contentResult = actionResult as
				CreatedAtRouteNegotiatedContentResult<Alumno>;

			IHttpActionResult actionDeleteResult = controller.DeleteAlumno(contentResult.Content.Id);
			var contentDeleteResult = actionDeleteResult as OkNegotiatedContentResult<Alumno>;

			Assert.IsNotNull(contentDeleteResult);
			Assert.IsNotNull(contentDeleteResult.Content);

		}
	}
}