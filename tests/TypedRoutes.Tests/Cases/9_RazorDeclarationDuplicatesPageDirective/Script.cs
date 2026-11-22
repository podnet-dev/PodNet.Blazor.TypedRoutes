CollectionAssert.AreEqual(new List<string> { "/person/{id:int}", "/person/{id:int}/edit" }, MyComponent.AllPageRouteTemplates.ToList());
Assert.AreEqual("/person/{id:int}", MyComponent.PageRouteTemplate);
Assert.AreEqual("/person/1", MyComponent.PageUri1(1));
Assert.AreEqual("/person/1/edit", MyComponent.PageUri2(1));