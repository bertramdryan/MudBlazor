﻿using Bunit;
using FluentAssertions;
using MudBlazor.UnitTests.TestComponents.ButtonGroup;
using NUnit.Framework;
using static Bunit.ComponentParameterFactory;

namespace MudBlazor.UnitTests.Components
{
    [TestFixture]
    public class ButtonGroupTests : BunitTest
    {
        [Test]
        public void WithFullWidth_ThenAllButtonsStreched()
        {
            // Arrange

            var comp = Context.RenderComponent<ButtonGroupFullWidth>();

            // Assert

            comp.FindAll(".mud-button-group-root.mud-width-full").Count.Should().Be(1);
            comp.FindAll(".mud-button-root.mud-width-full").Count.Should().Be(3);
        }

        [Test]
        public void WithFullWidthAndHasOneButtonFullWidth_ThenOtherButtonsNotStreched()
        {
            // Arrange

            var comp = Context.RenderComponent<ButtonGroupFullWidthWithButtonFullWidth>();

            // Assert

            comp.FindAll(".mud-button-group-root.mud-width-full").Count.Should().Be(1);
            var buttonComps = comp.FindAll(".mud-button-root");
            buttonComps[0].ClassList.Should().Contain("mud-width-full");
            buttonComps[1].ClassList.Should().NotContain("mud-width-full");
            buttonComps[2].ClassList.Should().NotContain("mud-width-full");
        }
    }
}
