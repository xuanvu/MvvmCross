#region Copyright
// <copyright file="IMvxTargetBindingFactoryRegistry.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
// 
// Project Lead - Stuart Lodge, Cirrious. http://www.cirrious.com
#endregion
namespace Cirrious.MvvmCross.Binding.Interfaces.Bindings.Target.Construction
{
    public interface IMvxTargetBindingFactoryRegistry : IMvxTargetBindingFactory
    {
        void RegisterFactory(IMvxPluginTargetBindingFactory factory);
    }
}