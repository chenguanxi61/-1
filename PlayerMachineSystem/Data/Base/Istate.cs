
public interface Istate
{
    //接口状态机

    void Enter();
    void Exit();
    void LogicUpdate();
    void PhysicalUpdate();

    //基本逻辑
}
