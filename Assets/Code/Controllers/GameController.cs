using System.Collections.Generic;

public class GameController : IExecute, IInitialization, ILateExecute, IClean, IFixedExecute, IAwake
{
    private readonly List<IInitialization> _initializeControllers;
    private readonly List<IExecute> _executeControllers;
    private readonly List<ILateExecute> _lateControllers;
    private readonly List<IClean> _cleanupControllers;
    private readonly List<IFixedExecute> _fixedExecuteControllers;
    private readonly List<IAwake> _awakeExecuteControllers;

    public GameController()
    {
        _initializeControllers = new List<IInitialization>();
        _executeControllers = new List<IExecute>();
        _lateControllers = new List<ILateExecute>();
        _cleanupControllers = new List<IClean>();
        _fixedExecuteControllers = new List<IFixedExecute>();
        _awakeExecuteControllers = new List<IAwake>();
    }

    internal GameController Add(IController controller)
    {
        if(controller is IAwake awakeController)
        {
            _awakeExecuteControllers.Add(awakeController);
        }
        if (controller is IInitialization initializeController)
        {
            _initializeControllers.Add(initializeController);
        }

        if (controller is IExecute executeController)
        {
            _executeControllers.Add(executeController);
        }

        if (controller is ILateExecute lateExecuteController)
        {
            _lateControllers.Add(lateExecuteController);
        }

        if (controller is IClean cleanupController)
        {
            _cleanupControllers.Add(cleanupController);
        }

        if (controller is IFixedExecute fixedExecute)
        {
            _fixedExecuteControllers.Add(fixedExecute);
        }
        return this;
    }

    public void Remove(IController controller)
    {
        if (controller is IInitialization initializeController)
        {
            _initializeControllers.Remove(initializeController);
        }

        if (controller is IExecute executeController)
        {
            _executeControllers.Remove(executeController);
        }

        if (controller is ILateExecute lateExecuteController)
        {
            _lateControllers.Remove(lateExecuteController);
        }

        if (controller is IClean cleanupController)
        {
            _cleanupControllers.Remove(cleanupController);
        }

        if (controller is IFixedExecute fixedExecute)
        {
            _fixedExecuteControllers.Remove(fixedExecute);
        }
    }

    public void Execute()
    {
        _executeControllers?.ForEach(x => x.Execute());
    }

    public void Init()
    {
        _initializeControllers.ForEach(x => x.Init());
    }

    public void LateExecute()
    {
        _lateControllers?.ForEach(x => x.LateExecute());
    }

    public void Clean()
    {
        _cleanupControllers?.ForEach(x => x.Clean());
    }

    public void FixedExecute()
    {
        _fixedExecuteControllers?.ForEach(x => x.FixedExecute());
    }

    public void Awake()
    {
        _awakeExecuteControllers?.ForEach(x => x.Awake());
    }
}

